using CinnamonCinemasService.Logic;
using CinnamonCinemasService.Models;

namespace CinnamonCinemasService.Tests;

public class SeatBookingServiceTests
{
    private SeatBookingService _seatBookingService;
    [SetUp]
    public void Setup()
    {
        _seatBookingService = new SeatBookingService(); 
    }

    //[Test]
    //public void Test_If_Theater_Seating_Is_Set_As_Expected()
    //{
    //    //Arrange
    //    List<Seat> seatList = new List<Seat>();
    //    List<string> expectedSeatList = new List<string>(); 

    //    //char[] seatRows = { 'A', 'B', 'C' };
    //    //int[] seatNums = { 1, 2, 3, 4, 5 };

    //    //Act
    //    seatList = _seatBookingService.SetTheatreSeating();

    //    //Assert
    //    Assert.Pass();
    //}

    [Test]
    public void Test_Theatre_Seating_Got_Correct_Total_No_Of_Seats_As_Per_The_Input()
    {
        
    }
}