using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Models
{
    public class Artist_Event
    {
        public int IdArtist { get; set; }
        public int IdEvent { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Event Event { get; set; }

        public DateTime PerformanceDate { get; set; }

    }
}
