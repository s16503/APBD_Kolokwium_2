using APBD_Kolokwium_2.Requests;
using APBD_Kolokwium_2.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Services
{
    public interface IDbService
    {
        GetArtistResponse GetArtist(int id);
        string UpdatePerformenceTime(int id_art, int id_ev, UpdatePerformenceTimeRequest req);
    }
}
