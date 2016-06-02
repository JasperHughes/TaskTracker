using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Task_Tracker.DAO.Tables;
using System.Data;

namespace Task_Tracker.DAO
{
    static class DBInterface
    {
        private static SqlDataAdapter da;
        private static string connectionString = ConfigurationManager.ConnectionStrings["Task_Tracker.Properties.Settings.TaskTrackerConnectionString"].ConnectionString;

        private static void Initialize()
        {
            
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static List<Developer> GetDevelopers()
        {
            List<Developer> developers = new List<Developer>();

            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand("SELECT * FROM Developers ORDER BY FamilyName, GivenNames", connection))
            {
                connection.Open();
                try
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Developer developer = new Developer();
                        developer.ID = (int)reader["ID"];
                        developer.FamilyName = reader["FamilyName"].ToString();
                        developer.GivenNames = reader["GivenNames"].ToString();
                        developer.Email = reader["Email"].ToString();
                        developer.ContactNumber = reader["ContactNumber"].ToString();
                        developer.Active = (bool)reader["Active"];
                        developer.Notes = reader["Notes"].ToString();

                        developers.Add(developer);
                    }
                    reader.Close();

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }

            return developers;
        }

        public static void AddDeveloper(Developer developer)
        {
            string query = "INSERT INTO Developers(FamilyName, GivenNames, Email, ContactNumber, Active, Notes) "
                + "VALUES(@FamilyName, @GivenNames, @Email, @ContactNumber, @Active, @Notes)";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@FamilyName", developer.FamilyName);
                command.Parameters.AddWithValue("@GivenNames", developer.GivenNames);
                command.Parameters.AddWithValue("@Email", developer.Email);
                command.Parameters.AddWithValue("@ContactNumber", developer.ContactNumber);
                command.Parameters.AddWithValue("@Active", developer.Active);
                command.Parameters.AddWithValue("@Notes", developer.Notes);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }                
            }
        }

        public static void UpdateDeveloper(Developer developer)
        {
            string query = "UPDATE Developers SET FamilyName = @FamilyName, "
                + "GivenNames = @GivenNames, Email = @Email, ContactNumber = @ContactNumber, "
                + "Active = @Active, Notes = @Notes "
                + "WHERE ID = @ID";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@FamilyName", developer.FamilyName);
                command.Parameters.AddWithValue("@GivenNames", developer.GivenNames);
                command.Parameters.AddWithValue("@Email", developer.Email);
                command.Parameters.AddWithValue("@ContactNumber", developer.ContactNumber);
                command.Parameters.AddWithValue("@Active", developer.Active);
                command.Parameters.AddWithValue("@Notes", developer.Notes); 
                command.Parameters.AddWithValue("@ID", developer.ID);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
            }
        }
    }
}
