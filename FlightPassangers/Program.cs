namespace FlightPassangers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passanger[] passangers =
            {
                new FirstClassPassanger {AirMiles = 1_419, Name = "Susan"},
                new FirstClassPassanger {AirMiles = 16_562, Name = "Lucy"},
                new BusinessClassPassanger {Name = "Janice"},
                new CoachClassPassanger {CarryOnKG = 25.7, Name = "Dave"},
                new CoachClassPassanger {CarryOnKG = 0, Name = "Amit"}
            };

            foreach (Passanger passanger in passangers)
            {
                decimal flightCost = passanger switch
                {
                    FirstClassPassanger p when p.AirMiles > 35000 => 1500M,
                    FirstClassPassanger p when p.AirMiles > 15000 => 1750M,
                    FirstClassPassanger _                         => 2000M,
                    BusinessClassPassanger _                      => 1000M,
                    CoachClassPassanger p when p.CarryOnKG < 10.0 => 500M,
                    CoachClassPassanger _                         => 650M,
                    _                                             => 800M

                };
                Console.WriteLine($"Flight cost {flightCost:C} for {passanger}");

            }
        }
    }
}
