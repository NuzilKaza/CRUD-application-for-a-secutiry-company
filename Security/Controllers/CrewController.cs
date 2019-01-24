using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Security.Controllers
{
    class CrewController
    {
        private int crewId;
        private DataRow information;
        private DataController dataController;

        private string[] insertParamNames = { "@crew_id", "@crew_leader", "@crew_car_model" };
        private SqlDbType[] insertParamTypes = { SqlDbType.Int, SqlDbType.NChar, SqlDbType.NChar };
        private string[] deleteParamNames = { "@crew_id" };
        private SqlDbType[] deleteParamTypes = { SqlDbType.Int };
        private string[] updateParamNames = { "@crew_id", "@crew_leader", "@crew_car_model" };
        private SqlDbType[] updateParamTypes = { SqlDbType.Int, SqlDbType.NChar, SqlDbType.NChar };

        public CrewController(DataRow crewInformation)
        {
            this.information = crewInformation;
            Connect();
        }

        public CrewController(int crewId)
        {
            this.crewId = crewId;
            Connect();
        }

        public CrewController(DataController dataController)
        {
            this.dataController = dataController;
        }

        public int Insert()
        {
            object[] paramValues = { information["crew_id"], information["crew_leader"], information["crew_car_model"] };
            return dataController.ModifyData("Crew_Insert", CommandType.StoredProcedure, insertParamNames, insertParamTypes, paramValues);
        }

        public int Delete()
        {
            object[] paramValues = { crewId };
            return dataController.ModifyData("Crew_Delete", CommandType.StoredProcedure, deleteParamNames, deleteParamTypes, paramValues);
            
        }

        public DataTable GetAllCrews()
        {
            return dataController.CreateDataSource("Crews_Select_All", CommandType.StoredProcedure);
        }

        private void Connect()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString);
            dataController = new DataController(connection);
        }

        public int Update()
        {
            object[] paramValues = { information["crew_id"], information["crew_leader"], information["crew_car_model"] };
            return dataController.ModifyData("Crew_Update", CommandType.StoredProcedure, updateParamNames, updateParamTypes, paramValues);
        }
    }
}
