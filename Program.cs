

using GNET90_EFCORE03.Data;
using GNET90_EFCORE03.Models;
using Microsoft.EntityFrameworkCore;

using AppDbContext _context = new AppDbContext();

_context.Database.Migrate();

if (!_context.Students.Any())
{
    _context.Students.AddRange(
        new Student { Id = 1000, FullName = "Ava Johnson", Email = "ava.johnson@example.com", DOB = new DateTime(2001, 4, 12) },
        new Student { Id = 1001, FullName = "Liam Smith", Email = "liam.smith@example.com", DOB = new DateTime(2000, 9, 23) },
        new Student { Id = 1002, FullName = "Mia Brown", Email = "mia.brown@example.com", DOB = new DateTime(2002, 1, 8) },
        new Student { Id = 1003, FullName = "Noah Davis", Email = "noah.davis@example.com", DOB = new DateTime(1999, 7, 17) },
        new Student { Id = 1004, FullName = "Emma Wilson", Email = "emma.wilson@example.com", DOB = new DateTime(2001, 11, 30) }
    );

    await _context.SaveChangesAsync();
}
if (!_context.Enrollments.Any())
{
    _context.Enrollments.AddRange(
        new Enrollment { EnrollDate = new DateTime(2024, 1, 15), Progress = 100m, Status = Status.Completed, FinalGrade = 92m, CourseId = 1002, StudentId = 1000 },
        new Enrollment { EnrollDate = new DateTime(2024, 1, 18), Progress = 85m, Status = Status.Active, FinalGrade = 0m, CourseId = 1002, StudentId = 1002 },
        new Enrollment { EnrollDate = new DateTime(2024, 2, 1), Progress = 0, Status = Status.Dropped, FinalGrade = 0m, CourseId = 1002, StudentId = 1001 },
        new Enrollment { EnrollDate = new DateTime(2024, 2, 5), Progress = 100m, Status = Status.Completed, FinalGrade = 88m, CourseId = 1000, StudentId = 1003 },
        new Enrollment { EnrollDate = new DateTime(2024, 3, 10), Progress = 45m, Status = Status.Active, FinalGrade = 0m, CourseId = 1001, StudentId = 1004 },
        new Enrollment { EnrollDate = new DateTime(2024, 3, 12), Progress = 60m, Status = Status.Active, FinalGrade = 0m, CourseId = 1002, StudentId = 1001 },
        new Enrollment { EnrollDate = new DateTime(2024, 4, 2), Progress = 100m, Status = Status.Completed, FinalGrade = 95m, CourseId = 1002, StudentId = 1002 },
        new Enrollment { EnrollDate = new DateTime(2024, 4, 8), Progress = 0, Status = Status.Dropped, FinalGrade = 0m, CourseId = 1002, StudentId = 1000 }
    );

    await _context.SaveChangesAsync();
}