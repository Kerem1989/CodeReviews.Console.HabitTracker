
namespace Kerem.HabitTracker ;

    public class ConsoleMenu
    {
        public void Menu()
        {
            bool exit = false;
            Console.WriteLine("Welcome to the Habit Tracker!");
            Console.WriteLine();
            while (!exit)
            {
                HabitService habitService = new HabitService();
                Console.WriteLine();
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Create a new habit");
                Console.WriteLine("2. View all habits");
                Console.WriteLine("3. Delete a habit");
                Console.WriteLine("4. Update a habit");
                Console.WriteLine("5. Exit");
                int choice = int.TryParse(Console.ReadLine() ?? string.Empty, out choice) ? choice : 0;
                Console.WriteLine();
                switch (choice)
                {
                    case 1:
                        habitService.CreateHabit();
                        break;
                    case 2:
                        habitService.ViewHabit();
                        break;
                    case 3:
                        habitService.DeleteHabit();
                        break;
                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Select 1 to update habit name or 2 to update the date:");
                        int updateChoice = int.Parse(Console.ReadLine() ?? string.Empty);
                        if (updateChoice == 1) habitService.UpdateHabitName();
                        else if (updateChoice == 2) habitService.UpdateHabitDate();
                        else Console.WriteLine("Invalid option.");
                        Console.WriteLine();
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine();
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid option.");
                        break;
                } 
            }
            
        }
    }