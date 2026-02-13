using System;
using System.Data.Common;
using MySql.Data.MySqlClient;

public class Program
{
    private static string _connectionString = "Server=localhost; Database=db_todo; Uid=root; Pwd=;";

    public void Get()
    {
        
    }
    
    static public void Main(string[] args)
    {
        using (MySqlConnection connection = new MySqlConnection(_connectionString))
        {
            connection.Open();

            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM users";

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["username"]);
                    }
                }
            }
        }
    }
}
