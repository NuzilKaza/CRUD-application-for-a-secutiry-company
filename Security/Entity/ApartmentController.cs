using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entity
{
    class ApartmentController
    {
        private DataRow information;
        private DataController dataController;

        private string[] findApartmentIdParamNames = { "@house_id", "@apartment_number" };
        private SqlDbType[] findApartmentIdParamTypes = { SqlDbType.Int, SqlDbType.Int };
        private string[] insertParamNames = { "@apartment_id", "@client_id", "@house_id", "@apartment_number", "@apartment_floor", "@apartment_door_type", "@balcony", "@code_key" };
        private SqlDbType[] insertParamTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.TinyInt, SqlDbType.NChar, SqlDbType.Bit, SqlDbType.Bit };
        private string[] insertWithBalconyParamNames = { "@apartment_id", "@balcony_type" };
        private SqlDbType[] insertWithBalconyParamTypes = { SqlDbType.Int, SqlDbType.NChar };
        private string[] insertWithoutBalconyParamNames = { "@apartment_id" };
        private SqlDbType[] insertWithoutBalconyParamTypes = { SqlDbType.Int };

        public ApartmentController(DataRow information)
        {
            this.information = information;
            Connect();
        }

        public int GetApartmentId()
        {
            if (information["apartment_id"] != null)
            {
                return Convert.ToInt32(information["apartment_id"]);
            } else
            {
                return 0;
            }
        }
        public int GetApartmentId(int houseId, int maxApartmentId)
        {
            int apartmentId = ApartmentExists(houseId);
            if (apartmentId > 0)
            {
                return apartmentId;
            }
            else
            {
                return maxApartmentId + 1;
            }
        }

        public int ApartmentExists(int houseId)
        {
            object[] findApartmentIdParamValues = { houseId, GetApartmentNumber() };
            DataTable apartment = dataController.CreateDataSource("Apartment_Select", CommandType.StoredProcedure, findApartmentIdParamNames, findApartmentIdParamTypes, findApartmentIdParamValues);
            if (apartment.Rows.Count == 1)
            {
                return Convert.ToInt32(apartment.Rows[0]["apartment_id"]);
            }
            else
            {
                return 0;
            }
        }

        private int GetApartmentNumber()
        {
            string[] separators = { ", кв. " };
            string[] parts = information["apartment_address_in_contract"].ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return Convert.ToInt32(parts[1]);
        }

        public int Insert(int houseId, int clientId, int maxApartmentId)
        {
            information["apartment_id"] = GetApartmentId(houseId, maxApartmentId);
            object[] paramValues = { information["apartment_id"], clientId, houseId, GetApartmentNumber(),
                information["apartment_floor"], information["apartment_door_type"], information["balcony"], information["code_key"] };
            int result1 = dataController.ModifyData("Apartment_Insert", CommandType.StoredProcedure, insertParamNames, insertParamTypes, paramValues);

            int result2;
            if (Convert.ToBoolean(information["balcony"]))
            {
                object[] paramValuesWithBalcony = { information["apartment_id"], information["balcony_type"] };
                result2 = dataController.ModifyData("With_Balcony_Insert", CommandType.StoredProcedure, insertWithBalconyParamNames, insertWithBalconyParamTypes, paramValuesWithBalcony);
            } else
            {
                object[] paramValuesWithoutBalcony = { information["apartment_id"] };
                result2 = dataController.ModifyData("Without_Balcony_Insert", CommandType.StoredProcedure, insertWithoutBalconyParamNames, insertWithoutBalconyParamTypes, paramValuesWithoutBalcony);
            }

            return result1 & result2;
        }

        private void Connect()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString);
            dataController = new DataController(connection);
        }
    }
}
