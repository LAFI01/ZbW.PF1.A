using System;

namespace MB08.A12_1._6.Model
{
    public class Exam
    {
        public double Grade { get; set; }

        public DateTime Date { get; set; }

        public int Duration { get; set; }

        public Exam(DateTime date, int duration)
        {
            Date = date;
            Duration = duration;

        }

        public bool Equals(Exam other)
        {
            if (other == null)
                return false;
            if (other == this)
                return true;
            if (Date.Equals(other.Date) && Duration == other.Duration)
                return true;
            return false;
        }
    }
}