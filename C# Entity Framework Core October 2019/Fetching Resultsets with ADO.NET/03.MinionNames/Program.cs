using System;
using System.Data.SqlClient;

namespace _03.MinionNames
{
    class Program
    {
        private static string connectionString =
            "Server=DESKTOP-PE61018\\SQLEXPRESS;" +
            "Database=MinionsDB;" +
            "Integrated Security=true";

        static void Main(string[] args)
        {
            int villainId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            using (connection)
            {
                string queryText = $"SELECT Name FROM Villains WHERE Id = {villainId}";

                SqlCommand command = new SqlCommand(queryText, connection);

                string villainName = (string)command.ExecuteScalar();

                if (villainName == null)
                {
                    Console.WriteLine($"No villain with ID {villainId} exists in the database.");
                    return;
                }

                Console.WriteLine($"Villain: {villainName}");

                queryText = @$"SELECT ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum,
                                         m.Name, 
                                         m.Age
                                    FROM MinionsVillains AS mv
                                    JOIN Minions As m ON mv.MinionId = m.Id
                                   WHERE mv.VillainId = {villainId}
                                ORDER BY m.Name";

                command = new SqlCommand(queryText, connection);

                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("(no minions)");
                        reader.Close();
                        connection.Close();
                        return;
                    }

                    while (reader.Read())
                    {
                        string minionName = (string)reader["Name"];
                        long rowNum = (long)reader["RowNum"];
                        int minionAge = (int)reader["Age"];

                        Console.WriteLine($"{rowNum}. {minionName} {minionAge}");
                    }
                }
            }
        }
    }
}
