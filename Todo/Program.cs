using MySql.Data.MySqlClient;

public class Program
{
    private static string _connectionString = "connection";
    
    static public void Main(string[] args)
    {
        string connectionString =
            "Server=localhost;" +
            "Database=db_todo;" +
            "Uid=root;" +
            "Pwd=;";   // empty password if using default XAMPP

        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = "select * from users";
        
        Console.WriteLine(command.CommandText);
    }
}
