using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Project.LogicLayer;
using System.Data;
using System.Data.SqlClient;

namespace PRG282_Project.DataAccessLayer
{
    internal class StudentDataAccessHandler
    {
        string connectionString = $"Server = .; Initial Catalog = PRG282_Project; Integrated Security = True;";

        public void Create(Student student)
        {
            string query = @"INSERT INTO Student VALUES
                            (@StudentNumber, @FirstName, @Surname, @Picture, @DateOfBirth, @Gender, @Phone, @StreetAddress);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand(query, connection )) 
                {
                    command.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@Surname", student.Surname);
                    command.Parameters.AddWithValue("@Picture", student.Picture);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@Phone", student.Phone);
                    command.Parameters.AddWithValue("@StreetAddress", student.StreetAddress);

                    connection.Open();
                    command.ExecuteNonQuery();  
                    connection.Close();
                }
            }
        }

        public void Update(Student student)
        {
            string query = @"UPDATE Student SET
                            StudentNumber = @StudentNumber, 
                            FirstName = @FirstName, 
                            Surname = @Surname, 
                            Picture = @Picture, 
                            DateOfBirth = @DateOfBirth,
                            Gender = @Gender, 
                            Phone  = @Phone, 
                            StreetAddress = @StreetAddress;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                    command.Parameters.AddWithValue("@FirstName", student.FirstName);
                    command.Parameters.AddWithValue("@Surname", student.Surname);
                    command.Parameters.AddWithValue("@Picture", student.Picture);
                    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    command.Parameters.AddWithValue("@Gender", student.Gender);
                    command.Parameters.AddWithValue("@Phone", student.Phone);
                    command.Parameters.AddWithValue("@StreetAddress", student.StreetAddress);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    
        public DataTable Read()
        {
            string query = @"SELECT * FROM Student";
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection (connectionString))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    connection.Open();
                    dataAdapter.Fill(table);
                    connection.Close();
                }
            }

            return table;
        }

        public DataTable Search(int studentNumber)
        {
            string query = @"SELECT * FROM Student WHERE StudentNumber = @StudentNumber";
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
   
        public void Delete(int studentNumber)
        {
            string query = @"DELETE Student WHERE StudentNumber = @StudentNumber;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StudentNumber", studentNumber);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        

        
    }
}
