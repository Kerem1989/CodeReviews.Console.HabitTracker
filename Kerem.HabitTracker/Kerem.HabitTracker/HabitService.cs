using Microsoft.Data.Sqlite;

namespace Kerem.HabitTracker ;

    public class HabitService
    {
        public void CreateHabit(SqliteConnection connection)
        {
            Habit habit = new Habit();
            Console.WriteLine("Please enter the name of the habit:");
            string name = habit.Name = Console.ReadLine() ?? string.Empty;
            DateTime occurance = habit.Occurance = DateTime.Now;
            using var command = connection.CreateCommand();
            command.CommandText = "INSERT INTO habit (name, occurance) VALUES ($name, $occurance)";
            command.Parameters.AddWithValue("$name", name);
            command.Parameters.AddWithValue("$occurance", occurance);
            command.ExecuteNonQuery();
        }
    }