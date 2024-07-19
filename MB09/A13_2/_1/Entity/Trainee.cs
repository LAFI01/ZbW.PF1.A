using System;
namespace MB09.A13_2._1.Entity
{
    class Trainee : Employee
    {
        private int maxEducationalYears;
        private int actualEducationalYear;

        public int MaxEducationalYears
        {
            get { return maxEducationalYears; }
            private set
            {
                if (value <= 5)
                    maxEducationalYears = value;
                else
                    throw new ArgumentException("value cannot be greater than 5!");
            }
        }

        public int ActualEducationalYear
        {
            get { return actualEducationalYear; }
            set
            {
                if (value <= MaxEducationalYears)
                    actualEducationalYear = value;
                else
                    throw new ArgumentException("max is reached!");
            }
        }

        public Trainee(string firstname, string lastname, int age,
            double salary, int maxEducationalYears,
            int actualEducationalYear) : base(firstname, lastname, age, salary)
        {
            MaxEducationalYears = maxEducationalYears;
            ActualEducationalYear = actualEducationalYear;
        }

        public Trainee(string firstname, string lastname,
           double salary, int maxEducationalYears,
           int actualEducationalYear) : this(firstname, lastname, 0,
             salary, maxEducationalYears, actualEducationalYear) { }

        public bool IncreaseEducationalYear()
        {
            if (ActualEducationalYear < MaxEducationalYears)
                ActualEducationalYear++;
            else
                return false;
            return true;
        }

        public string GetData()
        {
            return base.GetData() + " Maximal educational years: " + MaxEducationalYears +
                " Actual educational year" + ActualEducationalYear;
        }
    }
}