using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Seascape.Models.AppEntities
{
    public class Venue
    {
        public string Title { get; set; }
        public int SleepsAdults { get; set; }
        public int SleepsChildren { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public Address Address { get; set; }
    }

    public struct Address
    {
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
    }
}
