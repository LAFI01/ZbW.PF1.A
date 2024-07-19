
using MB08.A12_1._5.Model;


namespace MB08.A12_1._5.Controller
{
    public class Clock
    {
        private Digit hour;
        private Digit minute;
        private Digit second;

        public string Hour
        {
            get { return hour.getValueAsString(); }
        }

        public string Minute
        {
            get { return minute.getValueAsString(); }
        }

        public string Second
        {
            get { return second.getValueAsString(); }
        }

        public Clock() : this(0, 0, 0) { }

        public Clock(int hour, int minute, int second)
        {
            this.hour = new Digit(24);
            this.minute = new Digit(60);
            this.second = new Digit(60);
            SetTime(hour, minute, second);
        }

        public void SetTime(int hour, int minute, int second)
        {
            this.hour.Value = hour >= 0 && hour <= this.hour.Limit ? hour :
                throw new ArgumentException("Value of hour to big");
            this.minute.Value = minute >= 0 && minute <= this.minute.Limit ? minute :
                throw new ArgumentException("Value of minute to big");
            this.second.Value = second >= 0 && second <= this.second.Limit ? second :
                throw new ArgumentException("Value of second to big");
        }

        public void TriggerClockSignal()
        {
            second.Increase();
            if (second.Value == 0)
            {
                minute.Increase();
                if (minute.Value == 0)
                    hour.Increase();
            }
        }
    }
}