
namespace Kerem.HabitTracker ;

    public class HabitService
    {
        private readonly SqlService _sqlService = new SqlService();
        public void CreateHabit()
        {
            Console.WriteLine();
            var habit = new Habit();
            Console.WriteLine("Please enter the name of the habit:");
            string name = habit.Name = Console.ReadLine() ?? string.Empty;
            bool validText = ValidationHelper.ValidateTextInput(name);
            if (!validText) return;
            
            Console.WriteLine("If you want to enter the date, enter 0 or any key other than 0:");
            int userSelection = int.TryParse(Console.ReadLine() ?? string.Empty, out userSelection) ? userSelection : -1;
            DateTime date = DateTime.Now;
            if (userSelection == 0)
            {
                Console.WriteLine("Please enter the date of the habit:");
                date = habit.Date = DateTime.TryParse(Console.ReadLine() ?? string.Empty, out date) ? date : DateTime.Now;
            }
            else
            {
                date = habit.Date = DateTime.Now;
            }
            
            Console.WriteLine("Enter how many times you did the habit today:");
            int quantity = habit.Quantity = int.TryParse(Console.ReadLine() ?? string.Empty, out quantity) ? quantity : 0;
            bool validNumericalInput = ValidationHelper.ValidateNumericalInput(quantity);
            if (!validNumericalInput) return;
            
            _sqlService.InsertCommand(name, quantity, date);
            Console.WriteLine("Habit created successfully.");
            Console.WriteLine();
        }
        
        public void ViewHabit()
        {
            Console.WriteLine();
            Console.WriteLine("Habit list:");
            _sqlService.ViewAllCommand();
            Console.WriteLine();
        }
        
        public void DeleteHabit()
        {
            Console.WriteLine();
            _sqlService.ViewAllCommand();
            Console.WriteLine("Please enter the id of the habit you want to delete:");
            int habitId = int.TryParse(Console.ReadLine() ?? string.Empty, out habitId) ? habitId : -1;
            bool validNumericalInput = ValidationHelper.ValidateNumericalInput(habitId);
            if (!validNumericalInput) return;
            
            _sqlService.DeleteByIdCommand(habitId);
            Console.WriteLine("Habit deleted successfully.");
            Console.WriteLine();
        }
        
        public void UpdateHabitName()
        {
            Console.WriteLine();
            _sqlService.ViewAllCommand();
            Console.WriteLine("Please enter the id of the habit you want to update:");
            int habitId = int.TryParse(Console.ReadLine() ?? string.Empty, out habitId) ? habitId : 0;
            bool validNumericalInput = ValidationHelper.ValidateNumericalInput(habitId);
            if (!validNumericalInput) return;
            
            Console.WriteLine("Please enter the new name of the habit:");
            string habitName = Console.ReadLine() ?? string.Empty;
            bool validText = ValidationHelper.ValidateTextInput(habitName);
            if (!validText) return;
            
            _sqlService.UpdateNameById(habitId, habitName);
            Console.WriteLine("Habit updated successfully.");
            Console.WriteLine();
        }
        
        public void UpdateHabitDate()
        {
            Console.WriteLine();
            _sqlService.ViewAllCommand();
            Console.WriteLine("Please enter the id of the habit you want to update:");
            int habitId = int.TryParse(Console.ReadLine() ?? string.Empty, out habitId) ? habitId : 0;
            bool validNumericalInput = ValidationHelper.ValidateNumericalInput(habitId);
            if (!validNumericalInput) return;
            
            Console.WriteLine("Please enter the new date of the habit:");
            DateTime newDate = DateTime.TryParse(Console.ReadLine() ?? string.Empty, out newDate) ? newDate : DateTime.Now;
            _sqlService.UpdateDateById(habitId, newDate);
            Console.WriteLine("Habit updated successfully.");
            Console.WriteLine();
        }
        
        
    }