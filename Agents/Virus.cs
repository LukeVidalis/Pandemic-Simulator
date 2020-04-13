namespace Pandemic_Simulator.Agents
{
    public class Virus
    {
        public double InfectionRate { get; private set; }
        public double LethalityRate { get; private set; }
        public int MinInfectionDays { get; set; }
        public int MaxInfectionDays { get; set; }
        public int MinDaysBeforeSymptoms { get; set; }
        public int MaxDaysBeforeSymptoms { get; set; }

        public Virus(double InfectionRate, double LethalityRate)
        {
            this.InfectionRate = InfectionRate;
            this.LethalityRate = LethalityRate;
        }
    }
}