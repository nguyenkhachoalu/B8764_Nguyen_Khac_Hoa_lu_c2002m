using ExamApiAuction.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Config
{
    public class RolesConfig : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasIndex(u => u.Name);

            builder.Property(u => u.Name).IsRequired().HasMaxLength(100);
            builder.Property(u => u.CreateDate).IsRequired().HasDefaultValue(DateTime.Now);

        }
    }
}
