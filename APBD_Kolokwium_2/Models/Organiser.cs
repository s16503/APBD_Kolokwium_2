using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Models
{
    public class Organiser
    {
        public int IdOrganiser { get; set; }
        public string Name { get; set; }

        public ICollection<Event_Organiser> Events_Organiser { get; set; }

    }
}
