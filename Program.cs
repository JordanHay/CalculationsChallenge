using System;

namespace CalculationsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Temperature temperature = new Temperature();

            for (int i = 0; i < 100; i++)
            {
                temperature.Insert(rnd.Next(1, 101));
            }

            Console.WriteLine($"Min Temp: {temperature.MinimumTemperature}");
            Console.WriteLine($"Max Temp: {temperature.MaximumTemperature}");
            Console.WriteLine($"Avg Temp: {temperature.AverageTemperature}");

            Console.ReadLine();
        }
    }
}
