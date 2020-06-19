using APBD_Kolokwium_2.Models;
using APBD_Kolokwium_2.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Services
{
    public class EventsDbService : IDbService
    {
        public EventsDbContext _context { get; set; }
        public EventsDbService(EventsDbContext context)
        {
            _context = context;
        }

        public GetArtistResponse GetArtist(int id)
        {
            var artist = _context.Artists.Where(a => a.IdArtist == id).FirstOrDefault();

            if (artist == null)
                throw new Exception("nie znaleziono artysty o takim id");

            GetArtistResponse response = new GetArtistResponse();

            response.IdArtist = id;
            response.Nickname = artist.Nickname;

            var events = (from ae in _context.Artists_Events
                          join a in _context.Artists on ae.IdArtist equals a.IdArtist
                          join e in _context.Events on ae.IdEvent equals e.IdEvent
                          join eo in _context.Events_Organisers on e.IdEvent equals eo.IdEvent
                          join o in _context.Organisers on eo.IdOrganiser equals o.IdOrganiser
                          where a.IdArtist == id
                          orderby e.StartDate descending
                          select new EventResponse
                          {
                              IdEvent = e.IdEvent,
                              Name = e.Name,
                              OrganiserName = o.Name,
                              StartDate = e.StartDate,
                              EndDate = e.EndDate

                          }).ToList();


            response.Events = events;


            return response;

        }
    }
}
