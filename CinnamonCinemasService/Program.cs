// See https://aka.ms/new-console-template for more information
using CinnamonCinemasService.Logic;
using CinnamonCinemasService.Models;
using System.Runtime.CompilerServices;

SeatBookingService _seatBookingService = new();
_seatBookingService.BookSeats();
