using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02.Models
{
    public class OrganizerProfile
    {
        public int Id { get; set; }
        public string Bio {  get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }

        public int OrganizerId { get; set; }
    }
}
