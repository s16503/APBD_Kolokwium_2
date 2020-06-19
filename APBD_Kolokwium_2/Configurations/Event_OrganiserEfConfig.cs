using APBD_Kolokwium_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Configurations
{
    public class Event_OrganiserEfConfig : IEntityTypeConfiguration<Event_Organiser>
    {
        public void Configure(EntityTypeBuilder<Event_Organiser> builder)
        {
            builder.HasKey(e => new { e.IdEvent, e.IdOrganiser });

            var list = new List<Event_Organiser>();
            int id = 1;
            list.Add(new Event_Organiser { IdOrganiser = 1, IdEvent = 1 });
           


            builder.HasData(list);
        }
    }
}
