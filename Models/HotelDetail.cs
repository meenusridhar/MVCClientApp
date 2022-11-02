using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCClientApp.Models
{
    public class HotelDetail
    {
        public int HotelCode { get; set; }
        public string HotelName { get; set; }
        public double TotalRate { get; set; }
        public string Address { get; set; }
        public string Currency { get; set; }
        public string StarLevel { get; set; }

    }
}
