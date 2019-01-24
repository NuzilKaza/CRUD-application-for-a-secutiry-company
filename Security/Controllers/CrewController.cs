﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Security.Entities;

namespace Security.Controllers
{
    public class CrewController
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

        private DataTable crewsDataTable;

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

        public void Insert(Crew crew)
        {
            object[] paramValues = { crew.Id, crew.LeaderName, crew.CarModel };
            dataController.ModifyData("Crew_Insert", CommandType.StoredProcedure, insertParamNames, insertParamTypes, paramValues);
        }

        public int Delete()
        {
            object[] paramValues = { crewId };
            return dataController.ModifyData("Crew_Delete", CommandType.StoredProcedure, deleteParamNames, deleteParamTypes, paramValues);
            
        }

        public DataTable GetAllCrews()
        {
            crewsDataTable = dataController.CreateDataSource("Crews_Select_All", CommandType.StoredProcedure);
            return crewsDataTable;
        }

        public int GetMaxId()
        {
            int maxId = Convert.ToInt32(crewsDataTable.Rows[0]["crew_id"]);
            for (int i = 1; i < crewsDataTable.Rows.Count; i++)
            {
                DataRow row = crewsDataTable.Rows[i];
                if (maxId < Convert.ToInt32(row["crew_id"]))
                {
                    maxId = Convert.ToInt32(row["crew_id"]);
                }
            }

            return maxId;
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
