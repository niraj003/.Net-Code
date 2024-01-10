using System;

// Create a class Flight which stores Flight ID, Source,
// Destination, Arrival, Departure, Journey Time, ticket cost,
// flight capacity and total booked. Use a dictionary to store
// the list of flights as per the flight id. Provide following
// functions.
// 1) AddFilght( )
// 2) RemoveFlight( )
// 3) BookTicektsByFlightId( ) 
// 4) UpdateFlightCapacity( )
// 5) UpdateFlightArrival( )
// 6) UpdateFilghtDeparture( )
// 7) GetAllFlightsWithGivenSource( )
// 8) GetAllFlightsWithArrivalDateRange( )
// 9) FindReminaingCapacity( ) 

namespace Dictionary // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FlightDictionary f1 = new FlightDictionary();
            // f1.AddFilght();
        }
    }
}