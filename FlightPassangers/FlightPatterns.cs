using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightPassangers
{
    public class Passanger
    {
        public string? Name { get; set; }
    }

    public class BusinessClassPassanger : Passanger
    {
        public override string ToString()
        {
            return $"Business Class: {Name}";
        }
    }

    public class FirstClassPassanger : Passanger
    {
        public int AirMiles { get; set; }
        public override string ToString()
        {
            return $"First class with {AirMiles:N0} air miles: {Name}";
        }
    }
    public class CoachClassPassanger : Passanger
    {
        public double CarryOnKG { get; set; }
        public override string ToString()
        {
            return $"Coach Class with {CarryOnKG:N2} KG carry on: {Name}";
        }
    }
}
