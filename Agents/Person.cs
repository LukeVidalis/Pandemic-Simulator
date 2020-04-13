using Pandemic_Simulator.Enums;
using System;

namespace Pandemic_Simulator.Agents
{
    internal class Person
    {
        #region Properties

        public int Age { get; private set; }

        public Cautiousness CautiousnessLevel { get; set; }

        public HealthConditions HealthConditions { get; private set; }
        public double HealthStatus { get; private set; }

        public int DistanceTraveled { get; private set; } = 0;
        public double PropensityToTravel { get; private set; }

        public bool Infected { get; set; } = false;
        public bool Recovered { get; set; } = false;
        public int DaysSinceInfection { get; private set; } = -1;

        #endregion Properties

        public Person(int age, Cautiousness cautiousness, HealthConditions healthConditions)
        {
            Age = age;
            CautiousnessLevel = cautiousness;
            HealthConditions = healthConditions;

            //Generate Random Values for these attributes
            Random random = new Random();
            HealthStatus = random.NextDouble();
            PropensityToTravel = random.NextDouble();
        }
    }
}