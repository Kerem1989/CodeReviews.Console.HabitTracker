namespace Kerem.HabitTracker ;

    public class Habit
    {
        private string _name;
        private DateTime _occurance;
        
        public string Name { get; set; }
        public DateTime Occurance { get; set; }
        
        public Habit()
        {
            
        }
        public Habit(string name, DateTime occurance)
        {
            this._name = name;
            this._occurance = occurance;
        }
    }