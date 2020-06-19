using APBD_Kolokwium_2.Models;
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

      


    }
}
