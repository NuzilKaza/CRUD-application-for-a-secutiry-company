using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entity
{
    class ClientController
    {
        private DataRow information;
        private DataController dataController;

        private string[] findClientIdParamNames = { "@client_name", "@client_address", "@client_phone" };
        private SqlDbType[] findClientIdParamTypes = { SqlDbType.NChar, SqlDbType.NChar, SqlDbType.NChar };

        public ClientController(DataRow information)
        {
            this.information = information;
            Connect();
        }

        private int FindClientId()
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

        public int GetClientId(int maxClientId)
        {
            int clientId = FindClientId();
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
    }
}
