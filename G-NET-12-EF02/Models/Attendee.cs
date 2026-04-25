using G_NET_12_EF02.models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace G_NET_12_EF02.Models
{
    public class Attendee
    {
        [Key]
        public int AttendeeId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public Address Address { get; set; }

        public Badge Badge { get; set; }

        public ICollection<Registration> Registrations { get; set; }
            = new HashSet<Registration>();
    }
}
