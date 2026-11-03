using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GNET90_EFCORE03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET90_EFCORE03.Configuration
{
    public class CoursesConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {

            builder.Property(c => c.Title).IsRequired(true).HasMaxLength(50);
            builder.Property(c => c.Description).IsRequired(true).HasMaxLength(500);
            builder.Property(c => c.Price).IsRequired(true).HasPrecision(8, 2);
            builder.Property(c => c.PublishDate).IsRequired(true);

            builder.HasMany(c => c.Enrollments)
            .WithOne(e => e.Course)
            .HasForeignKey(e => e.CourseId)
            .IsRequired(true);
        }
    }
}