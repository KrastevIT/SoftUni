using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace _08.IncreaseMinionAge
{
    class Program
    {
        private static string connectionString =
            "Server=DESKTOP-PE61018\\SQLEXPRESS;" +
            "Database=MinionsDB;" +
            "Integrated Security=true";

        static void Main(string[] args)
        {
            int[] selectedIds = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SqlConnection dbCon = new SqlConnection(connectionString);
            dbCon.Open();

            List<int> minionIds = new List<int>();
            List<string> minionaNames = new List<string>();
            List<int> minionAges = new List<int>();

            using (dbCon)
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM Minions WHERE Id IN ({String.Join(", ", selectedIds)})", dbCon);
                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        dbCon.Close();
                        return;
                    }

                    while (reader.Read())
                    {
                        minionIds.Add((int)reader["Id"]);
                        minionaNames.Add((string)reader["Name"]);
                        minionAges.Add((int)reader["Age"]);
                    }
                }

                for (int i = 0; i < minionIds.Count; i++)
                {
                    int id = minionIds[i];
                    string name = String.Join(" ", minionaNames[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().Select(n => n = char.ToUpper(n.First()) + n.Substring(1).ToLower()).ToArray());
                    int age = minionAges[i] + 1;

                    command = new SqlCommand("UPDATE Minions SET Name = @name, Age = @age WHERE Id = @Id", dbCon);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@age", age);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }

                command = new SqlCommand($"SELECT * FROM Minions", dbCon);
                reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        dbCon.Close();
                        return;
                    }

                    while (reader.Read())
                    {
                        Console.WriteLine($"{(int)reader["Id"]} {(string)reader["Name"]} {(int)reader["Age"]}");
                    }
                }
            }
        }
    }
}
