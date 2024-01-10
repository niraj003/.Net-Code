using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Flight ID, Source,
// Destination, Arrival, Departure, Journey Time, ticket cost,
// flight capacity and total booked. 
namespace Dictionary
{
    public class Flight
    {
        public int FlightId { get;  set; }
        public string Source { get; set; }
        public string  Arrival { get; set; }
        public string Departure { get; set; }
        public string JourneyTime { get; set; }
        public int ticketCost { get; set; }
        public int? flightCapacity { get; set; }
        public int? totalBooked { get; set; }

    }
}