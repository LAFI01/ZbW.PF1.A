using System;

namespace MB09.A13_2._1.Entity
{
    class Employee : Person
    {
        private double salary;

        public int EmployeeNumber { get; set; }
        
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value > 0)
                    salary = value;
                else
                    throw new ArgumentException("wrong argument!");
            }
        }

        public static int CustomerCounter { get; set; } = 0;

        public Employee(string firstname, string lastname,
            int age, double salary) : base(firstname, lastname, age)
        {   
            EmployeeNumber = ++CustomerCounter;
            Salary = salary;    
        }

        public Employee(string firstname, string lastname,
             double salary) : this(firstname, lastname, 0, salary) { }

        public string GetData()
        {
            return base.GetData() + " Employeenumber: " + EmployeeNumber +
                " Salary: " + Salary;
        }
    }
}