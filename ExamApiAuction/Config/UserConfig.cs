using ExamApiAuction.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Config
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasIndex(u => u.Name).IsUnique(); 
            builder.HasIndex(u => u.Coin);
            builder.HasIndex(u => u.Email);
            builder.HasIndex(u => u.Phone).IsUnique();

            builder.Property(u => u.Name).IsRequired().IsUnicode().HasMaxLength(300);
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(20);
            builder.Property(u => u.Password).IsRequired();

            builder.Property(u => u.Coin).IsRequired();
            builder.Property(u => u.Email).IsRequired().IsUnicode().HasMaxLength(300);
            builder.Property(u => u.Phone).IsRequired().IsUnicode().HasMaxLength(300);

            builder.Property(u => u.Id_Roles).IsRequired();
            builder.Property(u => u.Incognito);
            builder.Property(u => u.CreateDate).IsRequired().HasDefaultValue(DateTime.Now);

            //Foreign Key
            //Roles Foreign Key
            builder.HasOne(r => r.roles)
                .WithMany(r => r.users)
                .HasForeignKey(r => r.Id_Roles)
                .OnDelete(DeleteBehavior.Cascade);
            

        } 
    }
}
