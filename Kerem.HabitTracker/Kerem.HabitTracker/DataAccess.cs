using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace Kerem.HabitTracker ;


    public class DataAccess
    {
        public SqliteConnection EstablishConnection()
        {
            String connectionString = @"Data Source=C:\Users\kerem\RiderProjects\CodeReviews.Console.HabitTracker\Kerem.HabitTracker\Database\habit.db;";
            SqliteConnection connection = new SqliteConnection(connectionString);
            connection.Open();
            return connection;
        }

        public void CreateHabitTable(SqliteConnection connection)
        {
            var command = connection.CreateCommand();
            command.CommandText = """
                CREATE TABLE habit (
                    id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                    name TEXT NOT NULL,
                    occurance DATETIME NOT NULL
                );
            """;
            command.ExecuteNonQuery();
            Console.WriteLine("Habit table created successfully.");
        }
    }