using ExamApiAuction.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.HasIndex(u => u.Name);

            builder.Property(u => u.Name).IsRequired().IsUnicode().HasMaxLength(300);
            builder.Property(u => u.M_Price);
            builder.Property(u => u.Id_Cate).IsRequired();

            builder.Property(u => u.DesCription).IsRequired().IsUnicode();
            builder.Property(u => u.SorfDescription).IsRequired().IsUnicode().HasMaxLength(300);

            builder.Property(u => u.Image).IsRequired();
            builder.Property(u => u.CreateDate).IsRequired().HasDefaultValue(DateTime.Now);
            //Foreign Key
            //Category 
            builder.HasOne(c => c.category)
                .WithMany(c => c.products)
                .HasForeignKey(c => c.Id_Cate)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
