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

        private string[] insertParamNames = { "@contract_id", "@apartment_id", "@commencement_date", "@expiration_date",
            "@payment_per_month", "@compensation", "@fine", "@additional" };
        private SqlDbType[] insertParamTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.Date, SqlDbType.Date,
            SqlDbType.Money, SqlDbType.Money, SqlDbType.Money, SqlDbType.Text };
        private string[] updateParamNames = {"@contract_id", "@apartment_id", "@commencement_date", "@expiration_date",
            "@validity_extention", "@payment_per_month", "@compensation", "@fine", "@additional" };
        private SqlDbType[] updateParamTypes = { SqlDbType.Int, SqlDbType.Int, SqlDbType.Date, SqlDbType.Date,
            SqlDbType.Date, SqlDbType.Money, SqlDbType.Money, SqlDbType.Money, SqlDbType.Text };

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

        public int Insert(int maxClientId, int maxHouseId, int maxApartmentId)
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

            ApartmentController apartmentController = new ApartmentController(information);
            int apartmentResult = 1;
            int houseId = houseController.GetHouseId(maxHouseId);
            int clientId = clientController.GetClientId(maxClientId);
            if (houseId != 0 && apartmentController.ApartmentExists(houseId) == 0)
            {
                apartmentResult = apartmentController.Insert(houseId, clientId, maxApartmentId);
            }

            int apartmentId = apartmentController.GetApartmentId(houseId, maxApartmentId);
            object[] paramValues = { information["contract_id"], apartmentId, information["commencement_date"], information["expiration_date"],
                information["payment_per_month"], information["compensation"], information["fine"], information["additional_conditions"] };
            int contractResult = dataController.ModifyData("Contract_Insert", CommandType.StoredProcedure, insertParamNames, insertParamTypes, paramValues);

            return clientResult & houseResult & apartmentResult & contractResult;
        }

        public int Update()
        {
            ClientController clientController = new ClientController(information);
            int clientResult = clientController.Update();

            HouseController houseController = new HouseController(information);
            int houseResult = houseController.Update();

            ApartmentController apartmentController = new ApartmentController(information);
            int apartmentResult = apartmentController.Update();

            object[] paramValues = { information["contract_id"], information["apartment_id"], information["commencement_date"], information["expiration_date"],
                information["validity_extention"], information["payment_per_month"], information["compensation"], information["fine"], information["additional_conditions"] };
            int contractResult = dataController.ModifyData("Contract_Update", CommandType.StoredProcedure, updateParamNames, updateParamTypes, paramValues);

            return clientResult & houseResult & apartmentResult & contractResult;
        }
    }
}
