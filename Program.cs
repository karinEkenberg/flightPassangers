using System;
using static flightPassangers.FlightPatterns;
namespace flightPassangers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passanger[] passangers =
            {
                new FirstClass {AirMiles =1_49, Name = "Karen"},
                new FirstClass {AirMiles = 16_562, Name = "Jan"},
                new BusinessClass {Name = "Molly"},
                new CoachClass {CarryOnKG = 22.2, Name = "Anna"},
                new CoachClass {CarryOnKG = 0, Name = "Ubbe"}
            };

            foreach (Passanger passanger in passangers)
            {
                decimal flightCost = passanger switch
                {
                    FirstClass p when p.AirMiles > 35000 => 1500M,
                    FirstClass p when p.AirMiles > 15000 => 1750M,
                    FirstClass _                         => 2000M,
                    BusinessClass _                      => 1000M,
                    CoachClass p when p.CarryOnKG < 10.0 => 500M,
                    CoachClass _                         => 650M,
                    _                                    => 800M,
                };
                Console.WriteLine($"Flight cost: {flightCost:C} for {passanger}");
            }
        }
    }
}
