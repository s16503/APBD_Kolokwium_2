using APBD_Kolokwium_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Configurations
{
    public class Artist_EventEfConfig : IEntityTypeConfiguration<Artist_Event>
    {
        public void Configure(EntityTypeBuilder<Artist_Event> builder)
        {
            builder.Property(a => a.PerformanceDate).IsRequired();
            builder.HasKey(a => new { a.IdEvent, a.IdArtist });


            var list = new List<Artist_Event>();
            int id = 1;
            list.Add(new Artist_Event { IdArtist = 1, IdEvent = 1, PerformanceDate = DateTime.Now.AddDays(1)});
            list.Add(new Artist_Event { IdArtist = 2, IdEvent = 1, PerformanceDate = DateTime.Now.AddDays(2) });
            list.Add(new Artist_Event { IdArtist = 1, IdEvent = 2, PerformanceDate = DateTime.Now.AddDays(21) });



            builder.HasData(list);
        }
    }
}
