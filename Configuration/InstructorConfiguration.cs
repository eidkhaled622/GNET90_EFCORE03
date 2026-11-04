using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GNET90_EFCORE03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GNET90_EFCORE03.Configuration
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(i => i.FullName).IsRequired().HasMaxLength(25);
            builder.Property(i => i.Email).IsRequired().HasMaxLength(50);
            builder.Property(i => i.Bio).HasMaxLength(100);
            builder.Property(i => i.JoinDate).IsRequired();

            builder.HasMany(a => a.Courses)
            .WithOne(c => c.Instructor)
            .HasForeignKey(c => c.InstructorId)
            .OnDelete(DeleteBehavior.Cascade);

            builder.HasKey(i => i.Id);

            builder.Property(c => c.Id)
                .UseIdentityColumn(seed: 1000, increment: 1);

            builder.HasData(
                new Instructor
                {
                    Id = 1000,
                    FullName = "Alex Morgan",
                    Email = "alex.morgan@example.com",
                    Bio = "Computer science instructor",
                    JoinDate = new DateTime(2020, 1, 15)
                },
                new Instructor
                {
                    Id = 1001,
                    FullName = "Jamie Lee",
                    Email = "jamie.lee@example.com",
                    Bio = "Software development instructor",
                    JoinDate = new DateTime(2021, 3, 10)
                },
                new Instructor
                {
                    Id = 1002,
                    FullName = "Taylor Reed",
                    Email = "taylor.reed@example.com",
                    Bio = "Database instructor",
                    JoinDate = new DateTime(2022, 5, 20)
                });
        }
    }
}