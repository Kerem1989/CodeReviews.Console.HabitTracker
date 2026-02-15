namespace Kerem.HabitTracker ;

    public class Habit
    {
        private string _name;
        private DateTime _date;
        private int _quantity;

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public int Quantity { get; set; }
        
        public Habit()
        {
            
        }

        public Habit(string name, DateTime date, int quantity)
        {
            Name = name;
            Date = date;
            Quantity = quantity;
        }

        
    }