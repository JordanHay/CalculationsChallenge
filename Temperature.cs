using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculationsChallenge
{
    public class Temperature
    {


            private List<int> temperatures = new List<int>();
            public int MinimumTemperature { get; set; }
            public int MaximumTemperature { get; set; }
            public double AverageTemperature { get; set; }

        public void Insert(int temperature)
        {
            temperatures.Add(temperature);
            MinimumTemperature = temperatures.Min();
            MaximumTemperature = temperatures.Max();
            AverageTemperature = temperatures.Average();
        }
        
    
    }
}
