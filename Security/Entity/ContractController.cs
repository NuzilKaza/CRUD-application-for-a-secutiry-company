using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security.Entity
{
    class ContractController
    {
        private DataRow information;
        private DataController dataController;

        public ContractController(DataRow information)
        {
            this.information = information;
            Connect();
        }

        private void Connect()
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionString);
            dataController = new DataController(connection);
        }

        public int Insert(int maxClientId, int maxHouseId)
        {
            ClientController clientController = new ClientController(information);
            int clientResult = 1;
            if (clientController.ClientExists() == 0)
            {
                clientResult = clientController.Insert(maxClientId);
            }

            HouseController houseController = new HouseController(information);
            int houseResult = 1;
            if (houseController.HouseExists() == 0)
            {
                houseResult = houseController.Insert(maxHouseId);
            }

            return clientResult & houseResult;
        }
    }
}
