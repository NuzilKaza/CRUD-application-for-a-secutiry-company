using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Security.Entities;

namespace Security.Controllers
{
    public class DepartureController
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

        private DataTable departuresDataTable;

        public DepartureController(DataRow departureInformation)
        {
            this.information = departureInformation;
            Connect();
        }

        public DataTable GetAllDepartures()
        {
            departuresDataTable = dataController.CreateDataSource("Departures_Select_All", CommandType.StoredProcedure);
            return departuresDataTable;
        }

        public DepartureController(DataController dataController)
        {
            this.dataController = dataController;
        }

        public int GetMaxId()
        {
            int maxId = Convert.ToInt32(departuresDataTable.Rows[0]["departure_id"]);
            for (int i = 1; i < departuresDataTable.Rows.Count; i++)
            {
                DataRow row = departuresDataTable.Rows[i];
                if (maxId < Convert.ToInt32(row["departure_id"]))
                {
                    maxId = Convert.ToInt32(row["departure_id"]);
                }
            }

            return maxId;
        }

        private void Connect()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString);
            dataController = new DataController(connection);
        }

        public void Update(Departure departure)
        {
            object[] paramValues = { departure.Id, departure.CrewId, departure.ContractId, departure.Date, departure.IsFalse };
            int result1 = dataController.ModifyData("Departure_Update", CommandType.StoredProcedure, updateParamNames, updateParamTypes, paramValues);

            int result2 = 1;
            if (departure.IsFalse)
            {
                if (!FalseDepartureExists(departure))
                {
                    object[] paramReplaceValues = { departure.Id };
                    result2 = dataController.ModifyData("Replace_True_Departure_With_False", CommandType.StoredProcedure, findDepartureParamNames, findDepartureParamTypes, paramReplaceValues);
                }
            }
            else
            {
                if (!TrueDepartureExists(departure))
                {
                    object[] paramReplaceValues = { departure.Id, departure.ArrestDocument };
                    result2 = dataController.ModifyData("Replace_False_Departure_With_True", CommandType.StoredProcedure, replaceParamNames, replaceParamTypes, paramReplaceValues);
                }
                else
                {
                    object[] paramUpdateTrueValues = { departure.Id, departure.ArrestDocument }; ;
                    result2 = dataController.ModifyData("Update_True_Departure", CommandType.StoredProcedure, updateTrueParamNames, updateTrueParamTypes, paramUpdateTrueValues);
                }
            }
        }

        private bool TrueDepartureExists(Departure departure)
        {
            int trueDepartureId = GetTrueDepartureId(departure);
            if (trueDepartureId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int GetTrueDepartureId(Departure departure)
        {
            object[] paramValues = { departure.Id };
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

        private bool FalseDepartureExists(Departure departure)
        {
            int falseDepartureId = GetFalseDepartureId(departure);
            if (falseDepartureId == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int GetFalseDepartureId(Departure departure)
        {
            object[] paramValues = { departure.Id };
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

        public void Insert(Departure departure)
        {
            object[] paramValues = { departure.Id, departure.CrewId, departure.ContractId, departure.Date, departure.IsFalse };
            dataController.ModifyData("Departure_Insert", CommandType.StoredProcedure, insertParamNames, insertParamTypes, paramValues);

            int result2;
            if (departure.IsFalse)
            {
                object[] paramValuesFalse = { departure.Id };
                result2 = dataController.ModifyData("False_Departure_Insert", CommandType.StoredProcedure, insertFalseParamNames, insertFalseParamTypes, paramValuesFalse);
            }
            else
            {
                object[] insertTrueParamValues = { departure.Id, departure.ArrestDocument };
                result2 = dataController.ModifyData("True_Departure_Insert", CommandType.StoredProcedure, insertTrueParamNames, insertTrueParamTypes, insertTrueParamValues);
            }
        }

        public Departure Select(int id)
        {
            DataRow row = departuresDataTable.Select(String.Format("departure_id = {0}", id))[0];
            int crewId = (int)row["crew_id"];
            int contractId = (int)row["contract_id"];
            DateTime date = Convert.ToDateTime(row["departure_date_time"]);
            bool falseCall = Convert.ToBoolean(row["false_call"]);
            Departure departure = new Departure(id, crewId, contractId, date, falseCall);

            if (!departure.IsFalse)
            {
                departure.ArrestDocument = row["arrest_document"].ToString();
            }

            return departure;
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
