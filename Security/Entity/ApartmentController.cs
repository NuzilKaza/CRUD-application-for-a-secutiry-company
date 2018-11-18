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

        public ApartmentController(DataRow information)
        {
            this.information = information;
            Connect();
        }

        public int GetApartmentId(int houseId, int maxApartmentId)
        {
            int apartmentId = FindApartmentId(houseId);
            if (apartmentId > 0)
            {
                return apartmentId;
            }
            else
            {
                return maxApartmentId + 1;
            }
        }

        private int FindApartmentId(int houseId)
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

        private void Connect()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString);
            dataController = new DataController(connection);
        }
    }
}
