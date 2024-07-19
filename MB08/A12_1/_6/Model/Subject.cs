namespace MB08.A12_1._6.Model
{
    public class Subject
    {
        private Exam[] exams;
        private int examsCounter;

        public string Name { get; set; }

        public Subject(string name, int numberOfExams)
        {
            Name = name;
            exams = new Exam[numberOfExams];
            examsCounter = 0;
        }

        public int GetNumberOfExams()
        {
            return exams.Length;
        }

        public int GetNumberOfCompletedExams()
        {
            return examsCounter;
        }

        public bool Equals(Subject other)
        {
            if (other == null)
                return false;
            if (other == this)
                return true;
            if (Name.Equals(other.Name))
                return true;
            return false;
        }

        public bool AddExam(Exam exam)
        {
            if (examsCounter < exams.Length && exam != null)
            {
                exams[examsCounter++] = exam;
                return true;
            }
            return false;
        }

        public Exam GetExam(int number)
        {
            if (number <= examsCounter)
                return exams[number];
            else
                return null;
        }

        public double[] GetAllGrades()
        {
            double[] grades = new double[examsCounter];
            for (int c = 0; c < examsCounter; c++)
            {
                grades[c] = exams[c].Grade;
            }
            return grades;
        }

        public Exam GetBestExam()
        {
            if (examsCounter > 0)
            {
                Exam best = exams[0];
                foreach (Exam e in exams)
                {
                    if (e.Grade > best.Grade)
                        best = e;
                }
                return best;
            }
            return null;
        }

        public Exam GetWorstExam()
        {
            if (examsCounter > 0)
            {
                Exam worst = exams[0];
                foreach (Exam e in exams)
                {
                    if (e.Grade < worst.Grade)
                        worst = e;
                }
                return worst;
            }
            return null;
        }

        public double GetGradePointAverage()
        {
            if (examsCounter > 0)
            {
                double sum = 0;
                for (int c = 0; c < examsCounter; c++)
                    sum += exams[c].Grade;
                return sum / examsCounter;
            }
            return -1;
        }
    }
}
