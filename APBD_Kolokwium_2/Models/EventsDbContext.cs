using APBD_Kolokwium_2.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Models
{
    public class EventsDbContext : DbContext
    {

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organiser> Organisers { get; set; }

        public DbSet<Artist_Event> Artists_Events { get; set; }

        public DbSet<Event_Organiser> Events_Organisers { get; set; }




        public EventsDbContext(DbContext service)
        {

        }


        public EventsDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ArtistEfConfig());
            modelBuilder.ApplyConfiguration(new OrganiserEfConfig());
            modelBuilder.ApplyConfiguration(new EventEfConfig());
            modelBuilder.ApplyConfiguration(new Artist_EventEfConfig());
            modelBuilder.ApplyConfiguration(new Event_OrganiserEfConfig());



        }



    }
}
