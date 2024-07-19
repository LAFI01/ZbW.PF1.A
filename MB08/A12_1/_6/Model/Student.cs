using System;
namespace MB08.A12_1._6.Model
{
    public class Student
    {
        private Subject[] subjects;
        private int subjectCounter;
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }

        public Student(string firstname, string lastname, DateTime birthday)
        {
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
            subjects = new Subject[20];
            subjectCounter = 0;
        }

        public bool AddSubject(Subject subject)
        {
            if (subjectCounter < subjects.Length && subject != null)
            {
                subjects[subjectCounter++] = subject;
                return true;
            }
            return false;
        }

        public Subject GetSubject(string name)
        {
            foreach (Subject s in subjects)
            {
                if (s.Name.Equals(name))
                    return s;
            }
            return null;
        }


        public string[] GetAllSubjectNames()
        {
            string[] names = new string[subjectCounter];
            for (int c = 0; c < subjectCounter; c++)
            {
                names[c] = subjects[c].Name;
            }
            return names;
        }

        public double GetGradePointAverageOfAllSubjects()
        {
            double sum = 0;
            for (int c = 0; c < subjectCounter; c++)
            {
                sum += subjects[c].GetGradePointAverage();
            }
            return sum / subjectCounter;
        }

        public string GetData()
        {
            return Firstname + " " + Lastname + " " + Birthday.ToShortDateString();
        }

        public bool Equals(Student other)
        {
            if (other == null)
                return false;
            if (other == this)
                return true;
            if (Firstname.Equals(other.Firstname) &&
                Lastname.Equals(other.Lastname) &&
                Birthday.Equals(other.Birthday))
            {
                return true;
            }
            return false;
        }
    }
}
