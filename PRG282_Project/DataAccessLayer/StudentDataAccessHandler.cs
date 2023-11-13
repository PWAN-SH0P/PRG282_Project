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
            string createQuery = @"INSERT INTO Student VALUES
                            (@StudentNumber, @FirstName, @Surname, @Picture, @DateOfBirth, @Gender, @Phone, @StreetAddress);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand createCommand = new SqlCommand(createQuery, connection )) 
                {
                    createCommand.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                    createCommand.Parameters.AddWithValue("@FirstName", student.FirstName);
                    createCommand.Parameters.AddWithValue("@Surname", student.Surname);
                    createCommand.Parameters.AddWithValue("@Picture", student.Picture);
                    createCommand.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    createCommand.Parameters.AddWithValue("@Gender", student.Gender);
                    createCommand.Parameters.AddWithValue("@Phone", student.Phone);
                    createCommand.Parameters.AddWithValue("@StreetAddress", student.StreetAddress);

                    connection.Open();
                    createCommand.ExecuteNonQuery();  
                    connection.Close();
                }
            }
        }

        public void Update(Student student)
        {
            string updateQuery = @"UPDATE Student SET
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
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@StudentNumber", student.StudentNumber);
                    updateCommand.Parameters.AddWithValue("@FirstName", student.FirstName);
                    updateCommand.Parameters.AddWithValue("@Surname", student.Surname);
                    updateCommand.Parameters.AddWithValue("@Picture", student.Picture);
                    updateCommand.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                    updateCommand.Parameters.AddWithValue("@Gender", student.Gender);
                    updateCommand.Parameters.AddWithValue("@Phone", student.Phone);
                    updateCommand.Parameters.AddWithValue("@StreetAddress", student.StreetAddress);

                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    
        public DataTable Read()
        {
            string readQuery = @"SELECT * FROM Student";
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection (connectionString))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(readQuery, connection))
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
            string searchQuery = @"SELECT * FROM Student WHERE StudentNumber = @StudentNumber";
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(searchQuery, connection))
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
            string deleteQuery = @"DELETE Student WHERE StudentNumber = @StudentNumber;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using(SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@StudentNumber", studentNumber);

                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        

        
    }
}
