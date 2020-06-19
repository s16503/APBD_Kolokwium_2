
using APBD_Kolokwium_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_Kolokwium_2.Configurations
{
    public class ArtistEfConfig : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasKey(a => a.IdArtist);
            builder.Property(a => a.IdArtist).ValueGeneratedOnAdd();
            builder.Property(a => a.Nickname).HasMaxLength(30).IsRequired();

            builder.HasMany(a => a.Artist_Events).WithOne(a => a.Artist).HasForeignKey(a => a.IdArtist);


            var list = new List<Artist>();
            int id = 1;
            list.Add(new Artist { IdArtist = id, Nickname ="Kazik"});
            list.Add(new Artist { IdArtist = id+1, Nickname = "Madonna" });


            builder.HasData(list);
        }
    }
}
