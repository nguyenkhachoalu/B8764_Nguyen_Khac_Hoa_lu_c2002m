using ExamApiAuction.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Config
{
    public class AuctionConfig : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasIndex(u => u.Id_Product);

            builder.Property(u => u.Id_Product).IsRequired();

            builder.Property(u => u.CreatTime).IsRequired();
            builder.Property(u => u.StartedDate).IsRequired();
            builder.Property(u => u.EndTime).IsRequired();
            
            builder.Property(u => u.Top_Price);
            builder.Property(u => u.Top_User);

            builder.Property(u => u.Status).IsRequired();

            //Foreign Key
            //Product
            builder.HasOne(p => p.product)
                .WithMany(p => p.auctions)
                .HasForeignKey(p => p.Id_Product)
                .OnDelete(DeleteBehavior.Cascade);
            //User
            builder.HasOne(u => u.user)
                .WithMany(u => u.auctions)
                .HasForeignKey(u => u.Top_User)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
