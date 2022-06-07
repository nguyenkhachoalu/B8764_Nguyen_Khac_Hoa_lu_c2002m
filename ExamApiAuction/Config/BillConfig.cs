using ExamApiAuction.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Config
{
    public class BillConfig : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.Id_Auction).IsRequired();

            builder.Property(u => u.CreateDate).IsRequired().HasDefaultValue(DateTime.Now);

            //Foreign Key
            //Auction
            builder.HasOne(a => a.auction)
                .WithMany(a => a.bills)
                .HasForeignKey(a => a.Id_Auction)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
