namespace Pandemic_Simulator
{
    public class Simulator
    {
        public TimeManager TimeManager { get; private set; }

        public Simulator()
        {
            TimeManager = new TimeManager();
        }
    }
}