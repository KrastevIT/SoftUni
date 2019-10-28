using System;
using System.Data.SqlClient;

namespace _09.IncreaseAgeStoredProcedure
{
    class Program
    {
        private static string connectionString =
            "Server=DESKTOP-PE61018\\SQLEXPRESS;" +
            "Database=MinionsDB;" +
            "Integrated Security=true";

        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(connectionString);

            dbCon.Open();

            int id = int.Parse(Console.ReadLine());

            using (dbCon)
            {
                var command = new SqlCommand("EXEC usp_GetOlder @Id", dbCon);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();

                command = new SqlCommand("SELECT * FROM Minions WHERE Id = @Id", dbCon);
                command.Parameters.AddWithValue("@Id", id);

                var reader = command.ExecuteReader();

                using (reader)
                {
                    reader.Read();

                    Console.WriteLine($"{(string)reader["Name"]} - {(int)reader["Age"]} years old");
                }
            }
        }
    }
}
