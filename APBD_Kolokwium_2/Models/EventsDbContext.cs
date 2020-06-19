using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Models
{
    public class EventsDbContext : DbContext
    {

        //  public DbSet<...> ... { get; set; }
        //  ...






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

            //modelBuilder.ApplyConfiguration(new ...Configuration());
            // ...


        }



    }
}
