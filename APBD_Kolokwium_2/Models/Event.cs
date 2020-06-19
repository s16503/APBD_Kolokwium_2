using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Models
{
    public class Event
    {
        public int IdEvent { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public ICollection<Artist_Event> Artists_Event { get; set; }
        public ICollection<Event_Organiser> Event_Organisers { get; set; }

    }
}
