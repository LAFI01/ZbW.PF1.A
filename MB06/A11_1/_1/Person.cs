using System;

namespace MB06.A11_1._1
{
    enum Color
    {
        blond, brown, red, black
    }

    class Person
    {
        private string firstname;
        private string lastname;
        private int age;
        private double height;

        public string Firstname
        {
            get { return firstname; }
            set 
            {
                if (value != null && value.Length > 0)
                    firstname = value;
                else
                    throw new ArgumentException("value cannot be null!");
            }
        }

        public string Lastname
        {
            get { return lastname; }

            set
            {
                if (value != null && value.Length>0)
                    lastname = value;
                else
                    throw new ArgumentException("value cannot be null!");
            }
        }

        

        public double Height
        {
            get { return height; }

            set
            {
                if (value >= 0)
                    height = value;
                else
                    throw new ArgumentException("value must be greater than 0!");
            }
        }

        public Color HairColor
        {
            get; set;
        }


        public int Age
        {
            get { return age;  }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    throw new ArgumentException("Value should not be less than 0!");
            }
        }
       
        // Konstruktor Überladung 
        //public Person(string fn, string ln, int age, double height, Color hairColor)
        //{
        //    Firstname = fn;
        //    Lastname = ln;
        //    Age = age;
        //    Height = height;
        //    HairColor = hairColor;
        //}

        //public Person(string fn, string ln)
        //{
        //    Firstname = fn;
        //    Lastname = ln;
        //    Age = 0;
        //    Height = 0;
        //    HairColor = Color.black;
        //}

        public string ShowValues()
        {
            return "Firstname: " + Firstname + ", " +
                "Lastname" + Lastname + ", " +
                "Age: " + Age + ", " +
                "Height: " + Height + ", " +
                "Hair-Color: " + Convert.ToString(HairColor);
        }
    }
}