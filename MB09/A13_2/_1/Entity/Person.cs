using System;

namespace MB09.A13_2._1.Entity
{
    class Person
    {
        private string firstname;
        private string lastname;
        private int age;

        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (value != null && value.Length > 0)
                    firstname = value;
                else
                    throw new ArgumentException("wrong arguments");
            }
        }

        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (value != null && value.Length > 0)
                    lastname = value;
                else
                    throw new ArgumentException("wrong arguments");
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value < 130)
                    age = value;
                else
                    throw new ArgumentException("wrong argument");
            }
        }

        public Person(string firstname, string lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public Person(string firstname, string lastname) : this(firstname, lastname, 0) { }

        public string GetData()
        {
            return "Firstname: " + Firstname + " " + "Lastname: " + Lastname + " " +
                "Age: " + Age;
        }
    }
}