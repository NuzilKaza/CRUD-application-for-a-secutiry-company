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
        private string[] updateParamNames = { "@apartment_id", "@client_id", "@house_id", "@apartment_number", "@apartment_floor", "@apartment_door_type", "@balcony", "@code_key" };
        private SqlDbType[] updateParamTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.TinyInt, SqlDbType.NChar, SqlDbType.Bit, SqlDbType.Bit };
        private string[] findApartmentParamNames = { "@apartment_id" };
        private SqlDbType[] findApartmentParamTypes = { SqlDbType.Int };
        private string[] replaceParamNames = { "@apartment_id", "@balcony_type" };
        private SqlDbType[] replaceParamTypes = { SqlDbType.Int, SqlDbType.NChar };
        private string[] updateWithBalconyParamNames = { "@apartment_id", "@balcony_type" };
        private SqlDbType[] updateWithBalconyParamTypes = { SqlDbType.Int, SqlDbType.NChar };

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

        public int Update()
        {
            int apartmentId = ApartmentExists((int)information["house_id"]);
            if (apartmentId > 0)
            {
                information["apartment_id"] = apartmentId;
            }

            object[] paramValues = { information["apartment_id"], information["client_id"], information["house_id"], GetApartmentNumber(),
                information["apartment_floor"], information["apartment_door_type"], information["balcony"], information["code_key"]  };
            int result1 = dataController.ModifyData("Apartment_Update", CommandType.StoredProcedure, updateParamNames, updateParamTypes, paramValues);

            int result2 = 1;
            if (Convert.ToBoolean(information["balcony"]))
            {
                if (!WithBalconyExists())
                {
                    object[] paramReplaceValues = { information["apartment_id"], information["balcony_type"] };
                    result2 = dataController.ModifyData("Replace_Without_Balcony_With_With", CommandType.StoredProcedure, replaceParamNames, replaceParamTypes, paramReplaceValues);
                }
                else
                {
                    object[] paramUpdateTrueValues = { information["apartment_id"], information["balcony_type"] }; ;
                    result2 = dataController.ModifyData("Update_With_Balcony", CommandType.StoredProcedure, updateWithBalconyParamNames, updateWithBalconyParamTypes, paramUpdateTrueValues);
                }
            } else
            {
                if (!WithoutBalconyExists())
                {
                    object[] paramReplaceValues = { information["apartment_id"] };
                    result2 = dataController.ModifyData("Replace_With_Balcony_With_Without", CommandType.StoredProcedure, findApartmentParamNames, findApartmentParamTypes, paramReplaceValues);
                }
            }

            return result1 & result2;
        }

        private bool WithBalconyExists()
        {
            int withBalconyId = GetWithBalconyId();
            if (withBalconyId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int GetWithBalconyId()
        {
            object[] paramValues = { information["apartment_id"] };
            DataTable apartmentWithBalcony = dataController.CreateDataSource("With_Balcony_Select", CommandType.StoredProcedure, findApartmentParamNames, findApartmentParamTypes, paramValues);
            if (apartmentWithBalcony.Rows.Count == 1)
            {
                return Convert.ToInt32(apartmentWithBalcony.Rows[0]["apartment_id"]);
            }
            else
            {
                return 0;
            }
        }

        private bool WithoutBalconyExists()
        {
            int withoutBalconyId = GetWithoutBalconyId();
            if (withoutBalconyId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int GetWithoutBalconyId()
        {
            object[] paramValues = { information["apartment_id"] };
            DataTable apartmentWithoutBalcony = dataController.CreateDataSource("Without_Balcony_Select", CommandType.StoredProcedure, findApartmentParamNames, findApartmentParamTypes, paramValues);
            if (apartmentWithoutBalcony.Rows.Count == 1)
            {
                return Convert.ToInt32(apartmentWithoutBalcony.Rows[0]["apartment_id"]);
            }
            else
            {
                return 0;
            }
        }

        private void Connect()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString);
            dataController = new DataController(connection);
        }
    }
}
