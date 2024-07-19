namespace MB09.A13_1._2
{
    public static class Calendar
    {
        public static int Count
        {
            get; private set;
        }

        public static bool LeapYear(int year)
        {
            Count++;
            bool isLeapYear = false;
            if (year % 4 == 0)
            {
                isLeapYear = true;
                if (year % 100 == 0)
                {
                    isLeapYear = false;
                    if (year % 400 == 0)
                        isLeapYear = true;
                }
            }
            return isLeapYear;
        }
    }
}