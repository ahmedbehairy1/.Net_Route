using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class Organizer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string? CompanyName { get; set; }
        public bool IsVerified { get; set; }

        public OrganizerProfile Profile { get; set; }


        public ICollection<Event> Events { get; set; } = new HashSet<Event>();

    }
}
