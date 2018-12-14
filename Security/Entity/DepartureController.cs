using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private string[] updateParamNames = { "@departure_id", "@crew_id", "@contract_id", "@departure_date_time", "@false_call" };
        private SqlDbType[] updateParamTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.Int, SqlDbType.DateTime, SqlDbType.Bit };
        private string[] findDepartureParamNames = { "@departure_id" };
        private SqlDbType[] findDepartureParamTypes = { SqlDbType.Int };
        private string[] replaceParamNames = { "@departure_id", "@arrest_document" };
        private SqlDbType[] replaceParamTypes = { SqlDbType.Int, SqlDbType.NChar };
        private string[] updateTrueParamNames = { "@departure_id", "@arrest_document" };
        private SqlDbType[] updateTrueParamTypes = { SqlDbType.Int, SqlDbType.NChar };

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

        public int Update()
        {
            object[] paramValues = { information["departure_id"], information["crew_id"], information["contract_id"], information["departure_date_time"], information["false_call"] };
            int result1 = dataController.ModifyData("Departure_Update", CommandType.StoredProcedure, updateParamNames, updateParamTypes, paramValues);

            int result2 = 1;
            if (Convert.ToBoolean(information["false_call"]))
            {
                if (!FalseDepartureExists())
                {
                    object[] paramReplaceValues = { information["departure_id"] };
                    result2 = dataController.ModifyData("Replace_True_Departure_With_False", CommandType.StoredProcedure, findDepartureParamNames, findDepartureParamTypes, paramReplaceValues);
                }
            }
            else
            {
                if (!TrueDepartureExists())
                {
                    object[] paramReplaceValues = { information["departure_id"], information["arrest_document"] };
                    result2 = dataController.ModifyData("Replace_False_Departure_With_True", CommandType.StoredProcedure, replaceParamNames, replaceParamTypes, paramReplaceValues);
                } else
                {
                    object[] paramUpdateTrueValues = { information["departure_id"], information["arrest_document"] }; ;
                    result2 = dataController.ModifyData("Update_True_Departure", CommandType.StoredProcedure, updateTrueParamNames, updateTrueParamTypes, paramUpdateTrueValues);
                }
            }

            return result1 & result2;
        }

        private bool TrueDepartureExists()
        {
            int trueDepartureId = GetTrueDepartureId();
            if (trueDepartureId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int GetTrueDepartureId()
        {
            object[] paramValues = { information["departure_id"] };
            DataTable trueDeparture = dataController.CreateDataSource("True_Departure_Select", CommandType.StoredProcedure, findDepartureParamNames, findDepartureParamTypes, paramValues);
            if (trueDeparture.Rows.Count == 1)
            {
                return Convert.ToInt32(trueDeparture.Rows[0]["departure_id"]);
            }
            else
            {
                return 0;
            }
        }

        private bool FalseDepartureExists()
        {
            int falseDepartureId = GetFalseDepartureId();
            if (falseDepartureId == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        private int GetFalseDepartureId()
        {
            object[] paramValues = { information["departure_id"] };
            DataTable falseDeparture = dataController.CreateDataSource("False_Departure_Select", CommandType.StoredProcedure, findDepartureParamNames, findDepartureParamTypes, paramValues);
            if (falseDeparture.Rows.Count == 1)
            {
                return Convert.ToInt32(falseDeparture.Rows[0]["departure_id"]);
            }
            else
            {
                return 0;
            }
        }

        public static DataTable SelectDepartures(DateTime startDate, DateTime finishDate)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString);
            DataController dataController = new DataController(connection);

            string[] paramNames = { "@start_date", "@finish_date" };
            SqlDbType[] paramTypes = { SqlDbType.DateTime, SqlDbType.DateTime };

            if (!IsToday(startDate) || !IsToday(finishDate))
            {
                object[] paramValues = { startDate, finishDate };
                return dataController.CreateDataSource("Departures_Select", CommandType.StoredProcedure, paramNames, paramTypes, paramValues);
            } else
            {
                return dataController.CreateDataSource("Departures_Select_All", CommandType.StoredProcedure);
            }
        }

        private static bool IsToday(DateTime date)
        {
            return date.Date == DateTime.Now.Date;
        }

    }
}
