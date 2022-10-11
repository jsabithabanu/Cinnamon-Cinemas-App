using CinnamonCinemasService.Logic;
using CinnamonCinemasService.Models;
using FluentAssertions;

namespace CinnamonCinemasService.Tests;

public class SeatBookingServiceTests
{
    private SeatBookingService _seatBookingService;
    [SetUp]
    public void Setup()
    {
        _seatBookingService = new SeatBookingService(); 
    }
    
    [Test]
    public void Test_Theatre_Seating_Got_Correct_Total_No_Of_Seats_As_Per_The_Input()
    {
        //Arrange
        List<Seat> seatList = new List<Seat>();

        char[] seatRows = { 'A', 'B', 'C' };
        int[] seatNums = { 1, 2, 3, 4, 5 };

        //Act
        seatList = _seatBookingService.SetTheatreSeating(seatRows, seatNums);

        //Assert
        seatList.Count().Should().Be(15);
    }   

}