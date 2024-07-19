
namespace MB07.A12_1._2
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public Person(string firstname, string lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        public string GetFieldsAsString()
        {
            return Firstname + "," + Lastname + ", " + Age;
        }
    }
}
