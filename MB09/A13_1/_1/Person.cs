
namespace MB09.A13_1._1
{
    class Person
    {
        public Person(string firstname, string lastname, int age)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Counter++;
        }

        public string Firstname { set; get; }
        public string Lastname { set; get; }
        public int Age { set; get; }

        public static int Counter
        {
             get; private set; 
        }
    }
}
