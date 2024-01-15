using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static flightPassangers.FlightPatterns;

namespace flightPassangers
{
    internal class FlightPatterns
    {
        public class Passanger
        {
            public string? Name { get; set; }
        }

        public class BusinessClass : Passanger
        {
            public override string ToString()
            {
                return $"Business Class: {Name}";
            }
        }

        public class FirstClass : Passanger
        {
            public int AirMiles { get; set; }
            public override string ToString()
            {
                return $"First Class with {AirMiles:N0} air miles: {Name}";
            }
        }

        public class  CoachClass : Passanger
        {
            public double CarryOnKG { get; set; }
            public override string ToString()
            {
                return $"Coach Class with {CarryOnKG} KG carry on: {Name}";
            }
        }

    }


}
