using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using GNET90_EFCORE03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET90_EFCORE03.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).IsRequired();
            builder.Property(c => c.Desc).IsRequired(false);

            builder.HasKey(c => c.ID);

            builder.Property(c => c.ID)
                .UseIdentityColumn(seed: 1000, increment: 1);

            builder.HasMany(ca => ca.Courses)
            .WithOne(c => c.Category)
            .HasForeignKey(co => co.CategoryId);

            builder.HasOne(ca => ca.Parent)
            .WithMany(ca => ca.SubCategory)
            .HasForeignKey(c => c.ParentID)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);
        }
    }
}