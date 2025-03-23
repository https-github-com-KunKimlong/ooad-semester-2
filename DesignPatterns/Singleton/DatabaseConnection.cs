using MySql.Data.MySqlClient;

public class DatabaseConnection
{
    private static DatabaseConnection _instance;
    private static readonly object _lock = new object();

    // Replace with your actual MySQL connection string
    private string connectionString = "Server=localhost;Database=PetStore;Uid=root;Pwd=yourpassword;";

    private DatabaseConnection() { }

    public static DatabaseConnection Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                        _instance = new DatabaseConnection();
                }
            }
            return _instance;
        }
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
}
