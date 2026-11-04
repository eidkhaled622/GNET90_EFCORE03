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
            .HasForeignKey(co => co.CategoryId)
            .IsRequired(true);

            builder.HasOne(ca => ca.Parent)
            .WithMany(ca => ca.SubCategory)
            .HasForeignKey(c => c.ParentID)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Category { ID = 1000, Name = "Programming", Desc = "Programming courses", ParentID = null },
                new Category { ID = 1001, Name = "Web Development", Desc = "Web development courses", ParentID = 1000 },
                new Category { ID = 1002, Name = "Databases", Desc = "Database courses", ParentID = 1001 },
                new Category { ID = 1003, Name = "Cloud Computing", Desc = "Cloud computing courses", ParentID = null },
                new Category { ID = 1004, Name = "Mobile Development", Desc = "Mobile development courses", ParentID = 1000 }
            );
        }
    }
}