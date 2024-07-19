using System;

namespace MB09.A13_2._1.Entity
{
    class Lead : Employee
    {
        private const int maxPosition = 5;
        private int position;

        public int Position
        {
            get { return position; }
            set
            {
                if (value > 0 && value < maxPosition)
                    position = value;
                else
                    throw new ArgumentException("wrong argument");
            }
        }

        public Lead(string firstname, string lastname, int age,
             double salary, int position) : 
            base (firstname, lastname, age, salary)
        {
            Position = position;
        }

        public Lead(string firstname, string lastname, 
            double salary, int position) : this(firstname, lastname, 0, 
                salary, position) { }

        public bool GetAPromotion()
        {
            if (position < maxPosition)
                position++;
            else
                return false;
            return true;
        }

        public string GetData()
        {
            return base.GetData() + " Position: " + Position;
        }
    }
}