using G_NET_12_EF02.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF02.Models
{
    public class Badge
    {
        public int BadgeId { get; set; }
        public string BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public BadgeTier Tier { get; set; }

        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }
    }
}
