
using MB08.A12_1._6.Model;
using System;

namespace MB08.A12_1._6.Controller
{
    public class ClassManager
    {
        private Student[] students;
        private int studentsCounter;

        public ClassManager()
        {
            students = new Student[50];
            studentsCounter = 0;
            GenerateTestClass();
        }

        public bool AddStudent(Student student)
        {
            if (studentsCounter < students.Length && student != null)
            {
                students[studentsCounter++] = student;
                return true;
            }
            return false;
        }

        public string[] GetDataOfStudents()
        {
            string[] names = new string[studentsCounter];
            for (int c = 0; c < studentsCounter; c++)
            {
                names[c] = students[c].GetData();
            }
            return names;
        }

        public string GetDataOfStudent(int pos)
        {
            Student student = students[pos];
            string[] data = student.GetAllSubjectNames();
            string result = "Student/in " + student.GetData() + " besucht die Fächer:\r\n\r\n";
            foreach (string s in data)
            {
                result += s + " - Noten: ";
                Subject sub = student.GetSubject(s);
                foreach (double grade in sub.GetAllGrades())
                {
                    result += grade + ", ";
                }
                if (sub.GetGradePointAverage() != -1)
                    result += "- Schnitt: " + sub.GetGradePointAverage();
                result += "\r\n";
            }
            return result;
        }

        public string GetBestStudent()
        {
            Student best = students[0];
            for (int c = 0; c < studentsCounter; c++)
            {
                if (students[c].GetGradePointAverageOfAllSubjects() >
                    best.GetGradePointAverageOfAllSubjects())
                {
                    best = students[c];
                }
            }
            return best.Firstname + " " + best.Lastname;
        }

        #region TestCase only for Testing
        public void GenerateTestClass()
        {
            // Creating Students
            AddStudent(new Student("Hans", "Keller", new DateTime(1990, 1, 14)));
            AddStudent(new Student("Petra", "Müller", new DateTime(1985, 5, 28)));
            AddStudent(new Student("Conrad", "Flusch", new DateTime(1991, 4, 12)));
            AddStudent(new Student("Nora", "Jones", new DateTime(1987, 12, 23)));
            AddStudent(new Student("Dominik", "Ammann", new DateTime(1999, 7, 18)));
            AddStudent(new Student("Petra", "Müller", new DateTime(1997, 8, 1)));
            AddStudent(new Student("Silvan", "Emmisegger", new DateTime(1990, 1, 14)));

            string[,] subjectdata = {
                { "Mathematik", "2" }, {"Englisch", "3" },
                {"Deutsch", "2"}, {"Marketing", "1" },
                {"Informatik", "3" }, {"Physik", "2"}
            };

            Random r = new Random();

            for (int y = 0; y < studentsCounter; y++)
            {

                for (int c = 0; c <= subjectdata.GetUpperBound(0); c++)
                {
                    // Assigning subjects to students
                    students[y].AddSubject(new Subject(subjectdata[c, 0],
                      Convert.ToInt16(subjectdata[c, 1])));
                }

                // Assigning exams for subjects to students
                Exam math1 = new Exam(new DateTime(2018, 5, 12), 60);
                // Generating random value for grade of exam
                math1.Grade = 3 + r.Next(0, 3);
                // Adding exam to students
                students[y].GetSubject("Mathematik").AddExam(math1);

                // Assigning exams for subjects to students
                Exam math2 = new Exam(new DateTime(2018, 7, 24), 60);
                // Generating random value for grade of exam
                math2.Grade = 3 + r.Next(0, 3);
                // Adding exam to students
                students[y].GetSubject("Mathematik").AddExam(math2);

                // Assigning exams for subjects to students
                Exam inf1 = new Exam(new DateTime(2018, 8, 12), 75);
                // Generating random value for grade of exam
                inf1.Grade = 3 + r.Next(0, 3); ;
                // Adding exam to students
                students[y].GetSubject("Informatik").AddExam(inf1);
            }
        }
        #endregion
    }
}
