namespace Kerem.HabitTracker ;

    public class ValidationHelper
    {
        public static bool ValidateTextInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty input. Input cannot be empty.");
                return false;
            }
            return true;
        }

        public static bool ValidateNumericalInput(int input)
        {
            if (input < 0)
            {
                Console.WriteLine("Invalid input. Input cannot be negative.");
                return false;
            }
            return true;
        }
    }