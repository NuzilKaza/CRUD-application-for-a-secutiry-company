using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Security
{
    public class DataController
    {
        private SqlConnection connection;

        public DataController(SqlConnection connection)
        {
            this.connection = connection;
        }

        public DataTable CreateDataSource(string commandText, CommandType commandType)
        {
            SqlCommand command = CreateCommand(commandText, commandType);
            return LoadData(command);
        }

        public DataTable CreateDataSource(
            string commandText,
            CommandType commandType,
            string[] paramNames,
            SqlDbType[] paramTypes,
            params object[] paramValues)
        {
            SqlCommand command = CreateCommand(commandText, commandType, paramNames, paramTypes, paramValues);
            return LoadData(command);
        }

        private DataTable LoadData(SqlCommand command)
        {
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                string columnName = reader.GetName(i);
                Type columnType = reader.GetFieldType(i);
                DataColumn dataColumn = new DataColumn(columnName, columnType);
                dataTable.Columns.Add(dataColumn);
            }

            while (reader.Read())
            {
                DataRow row = dataTable.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader.GetValue(i);
                }
                dataTable.Rows.Add(row);
            }

            connection.Close();
            return dataTable;
        }

        public int ModifyData(
            string commandText,
            CommandType commandType,
            string[] paramNames,
            SqlDbType[] paramTypes,
            params object[] paramValues)
        {
            SqlCommand command = CreateCommand(commandText, commandType, paramNames, paramTypes, paramValues);
            connection.Open();
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        private SqlCommand CreateCommand(string commandText, CommandType commandType)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = commandType;
            command.CommandText = commandText;
            return command;
        }

        private SqlCommand CreateCommand(
            string commandText,
            CommandType commandType,
            string[] paramNames,
            SqlDbType[] paramTypes,
            params object[] paramValues)
        {
            if (paramNames.Length != paramTypes.Length ||
                paramNames.Length != paramValues.Length ||
                paramTypes.Length != paramValues.Length)
            {
                throw new InvalidOperationException("Разное количество элементов в массивах");
            }

            SqlCommand command = CreateCommand(commandText, commandType);

            for (int i = 0; i < paramNames.Length; i++)
            {
                command.Parameters.Add(new SqlParameter(paramNames[i], paramTypes[i]));
                command.Parameters[paramNames[i]].Value = paramValues[i];
            }

            return command;
        }

        public int GetMaxId(DataTable dataTable, string columnName)
        {
            int maxId = Convert.ToInt32(dataTable.Rows[0][columnName]);
            for (int i = 1; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                if (maxId < Convert.ToInt32(row[columnName]))
                {
                    maxId = Convert.ToInt32(row[columnName]);
                }
            }

            return maxId;
        }

        internal int ModifyData(string v, CommandType storedProcedure, string[] updateTrueParamNames, SqlDbType[] updateTrueParamTypes, object paramUpdateTrueValues)
        {
            throw new NotImplementedException();
        }
    }
}
