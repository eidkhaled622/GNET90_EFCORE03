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

            builder.Property(c => c.Id)
                .UseIdentityColumn(seed: 1000, increment: 1);

            builder.HasMany(c => c.Enrollments)
            .WithOne(e => e.Course)
            .HasForeignKey(e => e.CourseId)
            .IsRequired(true);

            builder.HasKey(c => c.Id);

            builder.HasData(
                new Course { Id = 1001, Title = "C# Fundamentals", Description = "Introduction to C# programming.", Price = 49.99m, PublishDate = new DateTime(2024, 1, 1), IsPublished = true, InstructorId = 1000, CategoryId = 1000 },
                new Course { Id = 1002, Title = "Database Design", Description = "Core principles of relational database design.", Price = 59.99m, PublishDate = new DateTime(2024, 2, 1), IsPublished = true, InstructorId = 1001, CategoryId = 1000 },
                new Course { Id = 1003, Title = "Web Development", Description = "Build web applications with modern tools.", Price = 69.99m, PublishDate = new DateTime(2024, 3, 1), IsPublished = true, InstructorId = 1001, CategoryId = 1002 },
                new Course { Id = 1004, Title = "Cloud Computing", Description = "An introduction to cloud platforms and services.", Price = 79.99m, PublishDate = new DateTime(2024, 4, 1), IsPublished = false, InstructorId = 1002, CategoryId = 1000 },
                new Course { Id = 1005, Title = "API Development", Description = "Design and build reliable web APIs.", Price = 54.99m, PublishDate = new DateTime(2024, 5, 1), IsPublished = false, InstructorId = 1000, CategoryId = 1000 },
                new Course { Id = 1006, Title = "Software Testing", Description = "Learn software testing fundamentals and practices.", Price = 44.99m, PublishDate = new DateTime(2024, 6, 1), IsPublished = false, InstructorId = 1002, CategoryId = 1000 }
            );
        }
    }
}