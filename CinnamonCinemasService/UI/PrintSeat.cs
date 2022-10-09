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
            foreach (Seat seat in seatList)
            {
                Console.WriteLine("Seat Number : " + seat.SeatNumber);
                Console.WriteLine("Seat Satus : " + seat.EnumSeatStatus);
            }
        }
    }
}
