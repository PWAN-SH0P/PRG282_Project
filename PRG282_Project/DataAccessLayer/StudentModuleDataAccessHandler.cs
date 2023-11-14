using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.DataAccessLayer
{
    internal class ModuleDataHandler
    {
        string connectionString = $"Server = .; Initial Catalog = PRG282_Project; Integrated Security = True;";

        public DataTable FetchModules(int studentNumber)
        {
            string fetchModuleQuery = @"SELECT * FROM Module WHERE StudentNumber = @StudentNumber";
            DataTable moduleTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(fetchModuleQuery, connection))
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    connection.Open();
                    dataAdapter.Fill(moduleTable);
                    connection.Close();
                }
            }
            return moduleTable;
        }

        public void AddModule(int studentNumber, string moduleCode)
        {
            string addModuleQuery = @"INSERT INTO StudentModule VALUES (@StudentNumber,@ModuleCode);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand addModuleCommand = new SqlCommand(addModuleQuery, connection))
                {
                    addModuleCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    addModuleCommand.Parameters.AddWithValue("@ModuleCode", moduleCode);
                }
            }
        }

        public void RemoveModule(int studentNumber, string moduleCode)
        {
            string removeModuleQuery = @"DELETE StudentModule WHERE StudentNumber = @StudentNumber AND ModuleCode = @ModuleCode;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand removeModuleCommand = new SqlCommand(removeModuleQuery, connection))
                {
                    removeModuleCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    removeModuleCommand.Parameters.AddWithValue("@ModuleCode", moduleCode);
                }
            }
        }
        
        public List<string> ModuleList()
        {
            string fetchCodesQuery = @"SELECT Code FROM Module;";
            List<string> listOfCodes = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand fetchCodesCommand = new SqlCommand(fetchCodesQuery, connection))
                {
                    using(SqlDataReader reader = fetchCodesCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string code = reader.GetString(0);
                            listOfCodes.Add(code);
                        }
                    }
                }
            }
            return listOfCodes;
        }
    }
}
