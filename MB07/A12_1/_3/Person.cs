namespace MB07.A12_1._3
{
    class Person
    {
        public Person(string firstname, string lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public bool Equals(Person other)
        {
            if (other == null)
                return false;
            if (Firstname == other.Firstname &&
                Lastname == other.Lastname &&
                Age == other.Age)
                return true;
            return false;
        }

        public string GetPersonAsString()
        {
            return Firstname + " " + Lastname + " " + Age;
        }
    }
}