using APBD_Kolokwium_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Configurations
{
    public class OrganiserEfConfig : IEntityTypeConfiguration<Organiser>
    {
        public void Configure(EntityTypeBuilder<Organiser> builder)
        {
            builder.HasKey(o => o.IdOrganiser);
            builder.Property(o => o.Name).HasMaxLength(30).IsRequired();
            builder.HasMany(o => o.Events_Organiser).WithOne(o => o.Organiser).HasForeignKey(o => o.IdOrganiser);


            var list = new List<Organiser>();
            int id = 1;
            list.Add(new Organiser { IdOrganiser = id, Name = "Orange"});



            builder.HasData(list);
        }
    }
}
