using G_NET_12_EF02.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_EF02.models
{
    public class Registration
    {
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public string NoteToOrganizer { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}
