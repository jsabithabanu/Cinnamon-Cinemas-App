using CinnamonCinemasService.Models;
using CinnamonCinemasService.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinnamonCinemasService.Logic
{
    public class SeatBookingService
    {
        List<Seat> seatList = new();
        Seat? seat;
        Customer customer = new();
        PrintSeat printSeat = new();

        //For TDD purpose - passed input as parameters
        public List<Seat> SetTheatreSeating(char[] seatRows, int[] seatNums)
        {  
            foreach (var row in seatRows)
            {
                foreach (var number in seatNums)
                {
                    seat = new Seat();
                    seat.SeatNumber = row.ToString() + number.ToString();
                    seat.EnumSeatStatus = SeatSatus.Available;
                    seatList.Add(seat);
                }
            }
            return seatList;
        }

        //For console app - Inbuilt theatre setting for seating
        public List<Seat> SetTheatreSeating()
        {
            char[] seatRows = { 'A', 'B', 'C' };
            int[] seatNums = { 1, 2, 3, 4, 5 };

            foreach (var row in seatRows)
            {
                foreach(var number in seatNums)
                {
                    seat = new Seat();
                    seat.SeatNumber = row.ToString() + number.ToString();
                    seat.EnumSeatStatus = SeatSatus.Available;
                    seatList.Add(seat);
                }           
            }            
            return seatList;
        }

        public void BookSeats()
        {
            int totalBookedSeats = 0;
            int updatedNoOfSeats = 0;
            seatList = SetTheatreSeating();
            
            while (totalBookedSeats < seatList.Count())
            {
                var noOfSeatsRequested = customer.SeatRequest();
                var totalAvailableSeats = seatList.Count() - totalBookedSeats;

                if (noOfSeatsRequested <= totalAvailableSeats)
                {
                    while (noOfSeatsRequested != updatedNoOfSeats)
                    {
                        foreach (var seat in seatList)
                        {
                            if (seat.EnumSeatStatus == SeatSatus.Available)
                            {
                                seat.EnumSeatStatus = SeatSatus.Taken;
                                totalBookedSeats++;
                                updatedNoOfSeats++;
                            }
                            if (updatedNoOfSeats == noOfSeatsRequested)
                            {
                                updatedNoOfSeats = 0;
                                break;
                            }
                        }
                        break;
                    }
                }
                else
                {
                    printSeat.PrintCannotBookRequestedSeats(noOfSeatsRequested, totalAvailableSeats);
                    break;
                }
            }
            printSeat.PrintBookedAndAvailableSeats(seatList);
        }
    }
}
