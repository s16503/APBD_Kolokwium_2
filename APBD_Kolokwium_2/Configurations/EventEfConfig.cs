using APBD_Kolokwium_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Configurations
{

    public class EventEfConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => e.IdEvent);
            builder.Property(e => e.IdEvent).ValueGeneratedOnAdd();
            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.StartDate).IsRequired();
            builder.Property(e => e.EndDate).IsRequired();

            builder.HasMany(a => a.Artists_Event).WithOne(a => a.Event).HasForeignKey(a => a.IdEvent);
            builder.HasMany(a => a.Event_Organisers).WithOne(a => a.Event).HasForeignKey(a => a.IdEvent);


            var list = new List<Event>();
            int id = 1;
            list.Add(new Event { IdEvent = id, Name = "Opole 2020",StartDate = DateTime.Now, EndDate=DateTime.Now.AddDays(5) });
        


            builder.HasData(list);

        }
    }
}
