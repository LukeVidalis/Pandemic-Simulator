namespace Pandemic_Simulator
{
    public class TimeManager
    {
        public int CurrentDay { get; private set; }
        private readonly int DayInterval;

        public TimeManager()
        {
            CurrentDay = 0;
            DayInterval = 0;
        }

        public TimeManager(int DayInterval)
        {
            CurrentDay = 0;
            this.DayInterval = DayInterval;
        }

        public void AddDay()
        {
            CurrentDay += DayInterval;
        }
    }
}