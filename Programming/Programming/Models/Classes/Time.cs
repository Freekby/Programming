namespace Programming
{
    public class Time
    {
        private int hours;
        private int minutes;
        private int seconds;

        public Time()
        {
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException("Часы должны быть в диапазоне от 0 до 23.");
                }
                hours = value;
            }
        }

        public int Minutes
        {
            get { return minutes; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException("Минуты должны быть в диапазоне от 0 до 60.");
                }
                minutes = value;
            }
        }

        public int Seconds
        {
            get { return seconds; }
            set
            {
                if (value < 0 || value > 60)
                {
                    throw new ArgumentException("Секунды должны быть в диапазоне от 0 до 60.");
                }
                seconds = value;
            }
        }
    }
}
