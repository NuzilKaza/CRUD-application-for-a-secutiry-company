using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Controllers
{
    class ClientController
    {
        private DataRow information;
        private DataController dataController;

        private string[] findClientIdParamNames = { "@client_name", "@client_address", "@client_phone" };
        private SqlDbType[] findClientIdParamTypes = { SqlDbType.NChar, SqlDbType.NChar, SqlDbType.NChar };
        private string[] insertParamNames = { "@client_id", "@client_name", "@client_address", "@client_phone" };
        private SqlDbType[] insertParamTypes = { SqlDbType.Int, SqlDbType.NChar, SqlDbType.NChar, SqlDbType.NChar };
        private string[] updateParamNames = { "@client_id", "@client_name", "@client_address", "@client_phone" };
        private SqlDbType[] updateParamTypes = { SqlDbType.Int, SqlDbType.NChar, SqlDbType.NChar, SqlDbType.NChar };

        public ClientController(DataRow information)
        {
            this.information = information;
            Connect();
        }

        public int ClientExists()
        {
            object[] findClientIdParamValues = { information["client_name"], information["client_address"], information["client_phone"] };
            DataTable client = dataController.CreateDataSource("Client_Select", CommandType.StoredProcedure, findClientIdParamNames, findClientIdParamTypes, findClientIdParamValues);
            if (client.Rows.Count == 1)
            {
                return Convert.ToInt32(client.Rows[0]["client_id"]);
            }
            else
            {
                return 0;
            }
        }

       public int Insert(int maxClientId)
        {
            information["client_id"] = GetClientId(maxClientId);
            object[] paramValues = { information["client_id"], information["client_name"], information["client_address"], information["client_phone"] };
            int result = dataController.ModifyData("Client_Insert", CommandType.StoredProcedure, insertParamNames, insertParamTypes, paramValues);
            return result;
        }

        public int GetClientId()
        {
            if (information["client_id"] != null)
            {
                return Convert.ToInt32(information["client_id"]);
            }
            else
            {
                return 0;
            }
        }

        public int GetClientId(int maxClientId)
        {
            int clientId = ClientExists();
            if (clientId > 0)
            {
                return clientId;
            } else
            {
                return maxClientId + 1;
            }
        }

        private void Connect()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString);
            dataController = new DataController(connection);
        }

        public int Update()
        {
            int result = 1;
            int clientId = ClientExists();
            if (clientId > 0)
            {
                information["client_id"] = clientId;
            } else
            {
                object[] paramValues = { information["client_id"], information["client_name"], information["client_address"], information["client_phone"] };
                result = dataController.ModifyData("Client_Update", CommandType.StoredProcedure, updateParamNames, updateParamTypes, paramValues);
            }

            return result;
        }
    }
}
