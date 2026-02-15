using Microsoft.Data.Sqlite;

namespace Kerem.HabitTracker ;

    public class SqlService
    {
        private readonly DataAccess _dataAccess = new DataAccess();

        public void InsertCommand(string name, int quantity, DateTime date)
        {
            SqliteConnection connection = _dataAccess.EstablishConnection();
            var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO habit (name, quantity, date) VALUES ($name, $quantity, $date)";
            command.Parameters.AddWithValue("$name", name);
            command.Parameters.AddWithValue("$quantity", quantity);
            command.Parameters.AddWithValue("$date", date);
            command.ExecuteNonQuery();
        }
        
        public void ViewAllCommand()
        {
            SqliteConnection connection = _dataAccess.EstablishConnection();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM habit;";
            for (var reader = command.ExecuteReader(); reader.Read();)
                Console.WriteLine($"id: {reader[0]} " +
                                  $"name: {reader[1]} " +
                                  $"date: {reader[2]}");
        }
        
        public void DeleteByIdCommand(int id)
        {
            SqliteConnection connection = _dataAccess.EstablishConnection();
            var command = connection.CreateCommand();
            command.CommandText = "DELETE FROM habit WHERE id = $id";
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        public void UpdateNameById(int id, string name)
        {
            SqliteConnection connection = _dataAccess.EstablishConnection();
            var command = connection.CreateCommand();
            command.CommandText = "UPDATE habit SET name = $name WHERE id = $id";
            command.Parameters.AddWithValue("$name", name);
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }

        public void UpdateDateById(int id, DateTime date)
        {
            SqliteConnection connection = _dataAccess.EstablishConnection();
            var command = connection.CreateCommand();
            command.CommandText = "UPDATE habit SET date = $date WHERE id = $id";
            command.Parameters.AddWithValue("$date", date);
            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }
        
        
    }