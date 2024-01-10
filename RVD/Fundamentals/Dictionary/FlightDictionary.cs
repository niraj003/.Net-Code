using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dictionary
{
    public class FlightDictionary
    {   
         Dictionary<int, Flight> D1;
        public FlightDictionary(){
         D1 = new Dictionary<int, Flight>();
        }
// Flight ID, Source,
// Destination, Arrival, Departure, Journey Time, ticket cost,
// flight capacity and total booked.
 object a = new Flight();
        // public void AddFilght( int FlightId , string Source , string Destination , string Arrival , string JourneyTime, int ticketCost , int flightCapacity , int totalBooked ){
        //     D1.Add( FlightId , new Flight{FlightId = FlightId , Source = Source, Destination = Destination , Arrival=Arrival, JourneyTime= JourneyTime, ticketCost = ticketCost, flightCapacity= flightCapacity , totalBooked =totalBooked} );
        // }

        public void RemoveFlight( int FlightId){
            D1.Remove(FlightId);
        }

        public void UpdateFlightCapacity( int flightId , int newCapacity){
            D1[flightId].flightCapacity = newCapacity;
        }
    }
}