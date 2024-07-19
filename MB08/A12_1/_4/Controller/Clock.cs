using MB08.A12_1._4.Model;
using System;

namespace MB08.A12_1._4.Control
{
    public class Clock
    {
        private Digit hour;
        private Digit minute;

        public string Hour
        {
            get { return hour.getValueAsString(); }

        }

        public string Minute
        {
            get { return minute.getValueAsString(); }
        }

        public Clock() : this(0, 0) { }

        public Clock(int hour, int minute)
        {
            this.hour = new Digit(24);
            this.minute = new Digit(60);
            SetTime(hour, minute);
        }

        public void SetTime(int hour, int minute)
        {
            this.hour.Value = hour >= 0 && hour <= this.hour.Limit ? hour :
                throw new ArgumentException("Value to big");
            this.minute.Value = minute >= 0 && minute <= this.minute.Limit ? minute :
                throw new ArgumentException("Value to big");
        }

        public void TriggerClockSignal()
        {
            minute.Increase();
            if (minute.Value == 0)
                hour.Increase();
        }
    }
}
