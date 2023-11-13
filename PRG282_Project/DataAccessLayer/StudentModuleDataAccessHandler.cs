﻿using System;
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
            string query = @"SELECT * FROM Module WHERE StudentNumber = @StudentNumber";
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    connection.Open();
                    dataAdapter.Fill(table);
                    connection.Close();
                }
            }
            return table;
        }

        public void AddModule(int studentNumber, int moduleCode)
        {
            string query = @"INSERT INTO StudentModule VALUES (@StudentNumber,@ModuleCode);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@ModuleCode", moduleCode);
                }
            }
        }

        public void RemoveModule(int studentNumber, int moduleCode)
        {
            string query = @"DELETE StudentModule WHERE StudentNumber = @StudentNumber AND ModuleCode = @ModuleCode;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    command.Parameters.AddWithValue("@ModuleCode", moduleCode);
                }
            }
        }
    }
}
