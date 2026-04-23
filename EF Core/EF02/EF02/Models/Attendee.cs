using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Attendee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public Address Address { get; set; }

        public Badge Badge { get; set; }
        public ICollection<Registration> Registrations { get; set; } = new HashSet<Registration>();

    }
}
