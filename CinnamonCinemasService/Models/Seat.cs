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
        public string? SeatNumber { get; set; }
        public SeatSatus EnumSeatStatus { get; set; }
    }
}
