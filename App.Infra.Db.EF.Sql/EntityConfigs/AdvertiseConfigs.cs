using App.Domain.Core.Advertise.Entities;
using App.Domain.Core.User.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.EF.Sql.EntityConfigs
{
    public class AdvertiseConfigs : IEntityTypeConfiguration<Advertise>
    {
        public void Configure(EntityTypeBuilder<Advertise> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(100);
            builder.HasOne(p => p.City)
                .WithMany(p => p.CityAdvertises);
            builder.HasOne(p => p.Category)
                .WithMany(p => p.CategoryAdvertise);
            builder.HasMany(e => e.UserBookmarks)
        .WithMany(e => e.BookMark)
        .UsingEntity(
            "BookMark",
            l => l.HasOne(typeof(Advertise)).WithMany().HasForeignKey("AdvertiseId").HasPrincipalKey(nameof(Advertise.Id)),
            r => r.HasOne(typeof(User)).WithMany().HasForeignKey("UserId").HasPrincipalKey(nameof(User.Id)),
            j => j.HasKey("AdvertiseId", "UserId"));
            //builder.HasMany(p => p.UserBookmarks)
            //    .WithMany(p => p.BookMark)
            //.UsingEntity<BookMark>(
            //    j => j
            //        .HasOne(pt => pt.User)
            //        .WithMany(pt => pt.UserBookMarks)
            //        .HasForeignKey(p=>p.UserId),
            //    i => i
            //        .HasOne(pt => pt.Advertise)
            //        .WithMany(p => p.bookMarks)
            //        .HasForeignKey(pt => pt.AdvertiseId),
            //    j =>
            //    {
            //        j.Property(pt => pt.PublicationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            //        //builder.HasOne(p => p.AdvertiseUser)
            //        //    .WithMany(p => p.BookMark);
            //    }
            //    }
        }
    }
}
