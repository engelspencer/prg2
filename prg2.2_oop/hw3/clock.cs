using System;

namespace prg2._2_oop
{
    public class Clock
    {
        private int HOURS;
        private int MINUTES;
        private int SECONDS;
        private string TIME;

        public Clock(int hours, int minutes, int seconds)
        {
            HOURS = hours;
            MINUTES = minutes;
            SECONDS = seconds;
            TIME = HOURS.ToString() + ":" + MINUTES.ToString() + ":" + SECONDS.ToString();

            if(HOURS > 23 || MINUTES > 59 || SECONDS > 59)
            {
                throw new Exception("A military clock is restricted to less than 24 hours, 60 minutes, and 60 seconds.");
            }
        }

        public void Tick()
        {
            SECONDS++;
            if(SECONDS == 60)
            {
                SECONDS = 0;
                MINUTES++;
                if(MINUTES == 60)
                {
                    MINUTES = 0;
                    HOURS++;
                    if(HOURS == 24)
                    {
                        HOURS = 0;
                    }
                }
            }
        }

        public string DisplayTime()
        {
            return TIME;
        }

        public void SetTime(int hours, int minutes, int seconds)
        {
            HOURS = hours;
            MINUTES = minutes;
            SECONDS = seconds;
            TIME = HOURS.ToString() + ":" + MINUTES.ToString() + ":" + SECONDS.ToString();

            if(HOURS > 23 || MINUTES > 59 || SECONDS > 59)
            {
                throw new Exception("A military clock is restricted to less than 24 hours, 60 minutes, and 60 seconds.");
            }
        }
    }
}