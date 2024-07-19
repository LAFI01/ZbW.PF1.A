using System;

namespace MB09.A13_2._1.Entity
{
    enum CustomerType : int { A = 1, B = 2, C = 3, D = 4 }

    class Customer : Person
    {
        private int customerNumber;

        public CustomerType Type { get; set; }
        public int CustomerNumber
        {
            get { return customerNumber; }
            set
            {
                if (value > 0 )
                    customerNumber = value;
                else
                    throw new ArgumentException("wrong argument");
            }
        }

        public Customer(string firstname, string lastname, int age, 
            CustomerType type, int customerNumber) : base (firstname, lastname, age)
        {
            Type = type;
            CustomerNumber = customerNumber;
        }

        public Customer(string firstname, string lastname, CustomerType type,
            int customerNumber) : this(firstname, lastname, 0, type, customerNumber) { }
            
        public string GetData()
        {
            return base.GetData() + " Customertype: " + Type + " Customernumber: " +
                CustomerNumber;
        }
    }
}
