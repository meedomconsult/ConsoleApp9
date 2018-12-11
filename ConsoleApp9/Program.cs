using MySql.Data.MySqlClient;

namespace ConsoleApp9
{
    class Program
    {
        private MySqlConnection connection;

        public void RunConnection()
        {
            string connectionString = "server=localhost;port=3306;database=mysql;uid=root;pwd=my-secret-pw";
            using (connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand myCommand = new MySqlCommand("CREATE TABLE jme22 (f1 char(255))");
                myCommand.Connection = connection;
                myCommand.ExecuteNonQuery();
                myCommand.Dispose();
                connection.Close();
            }
        }

        static void Main(string[] args)
        {
            var p = new Program();
            p.RunConnection();
        }
    }
}
