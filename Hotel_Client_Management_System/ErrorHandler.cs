using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Client_Management_System
{
    public static class ErrorHandler
    {
        // Log error to a file
        public static void LogError(Exception ex)
        {
            string logFilePath = "Error_Log.txt";
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {ex.Message}");
                writer.WriteLine(ex.StackTrace);
                writer.WriteLine();
            }
        }

        // Log error to the database
        public static void LogErrorToDatabase(Exception ex)
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO ErrorLog (ErrorMessage, StackTrace) VALUES (@ErrorMessage, @StackTrace)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ErrorMessage", ex.Message);
                    cmd.Parameters.AddWithValue("@StackTrace", ex.StackTrace);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Handle error and show a user-friendly message
        public static void HandleError(Exception ex, string userMessage)
        {
            LogError(ex); // Log the error details
            LogErrorToDatabase(ex); // Optionally log to the database
            MessageBox.Show(userMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
