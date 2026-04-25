using G_NET_12_EF02.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace G_NET_12_EF02.models
{
    public class Organizer
    {
        [Key]
        public int OrganizerId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string CompanyName { get; set; }

        public bool IsVerified { get; set; }

        public OrganizerProfile OrganizerProfile { get; set; }

        public ICollection<Event> Events { get; set; }
     = new HashSet<Event>();
    }
}
