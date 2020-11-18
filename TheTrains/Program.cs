using System;

namespace TheTrains
{
    class Program
    {
        private static int CarriageCount = 46;

        static void Main(string[] args)
        {
            var simulator = new TrainSimulator(CarriageCount);

            var result = new TrainTaskResolver().Resolve(simulator);

            Console.WriteLine($"{result}");
            Console.ReadKey();
        }
    }
}