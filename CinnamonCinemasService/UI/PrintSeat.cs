using CinnamonCinemasService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonCinemasService.UI
{
    public class PrintSeat
    {  
        public void PrintBookedAndAvailableSeats(List<Seat> seatList)
        {
            Console.WriteLine("Seats Booked in Theatre :");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            foreach (Seat seat in seatList)
            {
                Console.WriteLine("Seat Number " + seat.SeatNumber + " is " + seat.EnumSeatStatus);
            }
        }

        public void PrintCannotBookRequestedSeats(int noOfSeatsRequested, int totalAvailableSeats)
        {
            Console.WriteLine("");
            Console.WriteLine($"Apologies as we are unable to book the no. of seats requested .The available seats are only {totalAvailableSeats}.");
            Console.WriteLine($"The booking is closed.");
            Console.WriteLine("");
            Console.WriteLine($"No. of seats requested : {noOfSeatsRequested}    Available no. of seats : {totalAvailableSeats}");
            Console.WriteLine("");
        }
    }
}
