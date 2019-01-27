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
    public class ContractController
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

        private DataTable contractsDataTable;

        public ContractController(DataRow information)
        {
            this.information = information;
            Connect();
        }

        public ContractController(DataController dataController)
        {
            this.dataController = dataController;
        }

        public int GetMaxId()
        {
            int maxId = Convert.ToInt32(contractsDataTable.Rows[0]["contract_id"]);
            for (int i = 1; i < contractsDataTable.Rows.Count; i++)
            {
                DataRow row = contractsDataTable.Rows[i];
                if (maxId < Convert.ToInt32(row["contract_id"]))
                {
                    maxId = Convert.ToInt32(row["contract_id"]);
                }
            }

            return maxId;
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

        public DataTable GetAllContracts()
        {
            contractsDataTable = dataController.CreateDataSource("Contracts_Select_All", CommandType.StoredProcedure);
            return contractsDataTable;
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

        public DataTable SelectContracts(string name, string address)
        {
            int apartmentNumber = 0;
            string houseAddress = "";
            string pattern = @", кв. \d+$";
            if (Regex.IsMatch(address, pattern))
            {
                string[] separators = { ", кв. " };
                string[] addressParts = address.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                houseAddress = addressParts[0];
                apartmentNumber = Convert.ToInt32(addressParts[1]);
            } else
            {
                houseAddress = address;
            }

            return LoadContracts(name, houseAddress, apartmentNumber);
        }

        private DataTable LoadContracts(string name, string houseAddress, int apartmentNumber)
        {
            string[] paramNames = { "@client_name", "@house_address", "@apartment_number" };
            SqlDbType[] paramTypes = { SqlDbType.NChar, SqlDbType.NChar, SqlDbType.Int};

            if (name == "" && houseAddress == "" && apartmentNumber == 0)
            {
                return contractsDataTable;
            }

            object[] paramValues = { null, null, null };
            if (name != "")
            {
                paramValues[0] = name;
            }
            if (houseAddress != "")
            {
                paramValues[1] = houseAddress;
            }
            if (apartmentNumber != 0)
            {
                paramValues[2] = apartmentNumber;
            }

            return dataController.CreateDataSource("Contract_Select", CommandType.StoredProcedure, paramNames, paramTypes, paramValues);
        }
    }
}
