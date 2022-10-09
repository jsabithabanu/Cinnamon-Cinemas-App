using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CinnamonCinemasService.Models
{
    public class Seat
    {
        //    public char SeatRow { get; set; }
        //    public int SeatNum { get; set; }
        //   // public List<Seat>? SeatList { get; set; }

        public string? SeatNumber { get; set; }
        public SeatSatus EnumSeatStatus { get; set; }
    }
}
