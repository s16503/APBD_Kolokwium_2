using APBD_Kolokwium_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Responses
{
    public class GetArtistResponse
    {
        public int IdArtist { get; set; }
        public string Nickname { get; set; }

        public IEnumerable<EventResponse> Events { get; set; }

    }
}
