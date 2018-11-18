using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entity
{
    class HouseController
    {
        private DataRow information;
        private DataController dataController;

        private string[] findHouseIdParamNames = { "@house_address" };
        private SqlDbType[] findHouseIdParamTypes = { SqlDbType.NChar };

        public HouseController(DataRow information)
        {
            this.information = information;
            Connect();
        }

        public int GetHouseId(int maxHouseId)
        {
            int houseId = FindHouseId();
            if (houseId > 0)
            {
                return houseId;
            }
            else
            {
                return maxHouseId + 1;
            }
        }

        private int FindHouseId()
        {
            object[] findHouseIdParamValues = { GetHouseAddress() };
            DataTable house = dataController.CreateDataSource("House_Select", CommandType.StoredProcedure, findHouseIdParamNames, findHouseIdParamTypes, findHouseIdParamValues);
            if (house.Rows.Count == 1)
            {
                return Convert.ToInt32(house.Rows[0]["house_id"]);
            }
            else
            {
                return 0;
            }
        }

        private string GetHouseAddress()
        {
            string[] separators = { ", кв. " };
            string[] parts = information["apartment_address_in_contract"].ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return parts[0];
        }
        
        private void Connect()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString);
            dataController = new DataController(connection);
        }
    }
}
