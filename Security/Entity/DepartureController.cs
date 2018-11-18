using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entity
{
    class DepartureController
    {
        private DataRow information;
        private DataController dataController;

        private string[] insertParamNames = { "@departure_id", "@crew_id", "@contract_id", "@departure_date_time", "@false_call" };
        private SqlDbType[] insertParamTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Bit };
        private string[] insertFalseParamNames = { "@departure_id" };
        private SqlDbType[] insertFalseParamTypes = { SqlDbType.Int };
        private string[] insertTrueParamNames = { "@departure_id", "@arrest_document" };
        SqlDbType[] insertTrueParamTypes = { SqlDbType.Int, SqlDbType.NChar };

        public DepartureController(DataRow departureInformation)
        {
            this.information = departureInformation;
            Connect();
        }

        public int Insert()
        {
            object[] paramValues = { information["departure_id"], information["crew_id"], information["contract_id"], information["departure_date_time"], information["false_call"] };
            int result1 = dataController.ModifyData("Departure_Insert", CommandType.StoredProcedure, insertParamNames, insertParamTypes, paramValues);

            int result2;
            if (Convert.ToBoolean(information["false_call"]))
            {
                object[] paramValuesFalse = { information["departure_id"] };
                result2 = dataController.ModifyData("False_Departure_Insert", CommandType.StoredProcedure, insertFalseParamNames, insertFalseParamTypes, paramValuesFalse);
            } else
            {
                object[] insertTrueParamValues = { information["departure_id"], information["arrest_document"] };
                result2 = dataController.ModifyData("True_Departure_Insert", CommandType.StoredProcedure,insertTrueParamNames, insertTrueParamTypes, insertTrueParamValues);
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
