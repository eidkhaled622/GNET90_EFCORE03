

using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using GNET90_EFCORE03.Data;
using GNET90_EFCORE03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Identity.Client.Extensibility;

using AppDbContext _context = new AppDbContext();

_context.Database.Migrate();

if (!_context.Students.Any())
{
    _context.Students.AddRange(
        new Student { FullName = "Ava Johnson", Email = "ava.johnson@example.com", DOB = new DateTime(2001, 4, 12) },
        new Student { FullName = "Liam Smith", Email = "liam.smith@example.com", DOB = new DateTime(2000, 9, 23) },
        new Student { FullName = "Mia Brown", Email = "mia.brown@example.com", DOB = new DateTime(2002, 1, 8) },
        new Student { FullName = "Noah Davis", Email = "noah.davis@example.com", DOB = new DateTime(1999, 7, 17) },
        new Student { FullName = "Emma Wilson", Email = "emma.wilson@example.com", DOB = new DateTime(2001, 11, 30) }
    );

    await _context.SaveChangesAsync();
}
if (!_context.Enrollments.Any())
{
    _context.Enrollments.AddRange(
        new Enrollment { EnrollDate = new DateTime(2024, 1, 15), Progress = 100m, Status = Status.Completed, FinalGrade = 92m, CourseId = 1002, StudentId = 1000 },
        new Enrollment { EnrollDate = new DateTime(2024, 1, 18), Progress = 85m, Status = Status.Active, FinalGrade = 100m, CourseId = 1002, StudentId = 1002 },
        new Enrollment { EnrollDate = new DateTime(2024, 2, 1), Progress = 0, Status = Status.Dropped, FinalGrade = 90m, CourseId = 1002, StudentId = 1001 },
        new Enrollment { EnrollDate = new DateTime(2024, 2, 5), Progress = 100m, Status = Status.Completed, FinalGrade = 88m, CourseId = 1000, StudentId = 1003 },
        new Enrollment { EnrollDate = new DateTime(2024, 3, 10), Progress = 45m, Status = Status.Active, FinalGrade = 100m, CourseId = 1001, StudentId = 1004 },
        new Enrollment { EnrollDate = new DateTime(2024, 3, 12), Progress = 60m, Status = Status.Active, FinalGrade = 30m, CourseId = 1000, StudentId = 1001 },
        new Enrollment { EnrollDate = new DateTime(2024, 4, 2), Progress = 100m, Status = Status.Completed, FinalGrade = 80m, CourseId = 1001, StudentId = 1002 },
        new Enrollment { EnrollDate = new DateTime(2024, 4, 8), Progress = 0, Status = Status.Dropped, FinalGrade = 90m, CourseId = 1000, StudentId = 1000 }
    );

    await _context.SaveChangesAsync();
}

#region Create Instructor
// var Instructor = new Instructor
// {
//     FullName = "Omar Eid",
//     Email = "KhaledEid@example.com",
//     Bio = "FullStack instructor",
//     JoinDate = new DateTime(2022, 5, 20)
// };
// await _context.Instructors.AddAsync(Instructor);
// await _context.SaveChangesAsync();
// Console.WriteLine($"The Id Of the instructor : ${Instructor.Id}");
#endregion

#region Create Course
// var InstructorId = 1006;
// var CategoryId = 1000;

// var InstructorExists = await _context.Instructors.FindAsync(InstructorId);
// var CategoryExists = await _context.Instructors.FindAsync(CategoryId);

// if (InstructorExists == null)
// {
//     Console.WriteLine("The Instructor Provided is not Existed");
// }
// else if (CategoryExists == null)
// {
//     Console.WriteLine("The Category Provided is not Existed");
// }
// else
// {
//     var Course = new Course
//     {
//         Title = "Clean Architecture in .NET",
//         Description = "Layers, dependencies and testing",
//         Price = 69.99m,
//         Level = CourseLevel.Intermediate,
//         IsPublished = true,
//         InstructorId = InstructorId,
//         CategoryId = CategoryId
//     };
//     await _context.AddAsync(Course);
//     await _context.SaveChangesAsync();
//     Console.WriteLine($"This Course Added : ${Course.Id}");
// }
#endregion

#region Add 3 Students
// var Students = new[] {
//     new Student { FullName = "Lucas Miller",   Email = "lucas.miller@example.com",   DOB = new DateTime(2000, 5, 19) },
//     new Student { FullName = "Sophia Taylor",  Email = "sophia.taylor@example.com",  DOB = new DateTime(2002, 8, 3) },
//     new Student { FullName = "Ethan Clark",    Email = "ethan.clark@example.com",    DOB = new DateTime(1998, 12, 27) }
// };
// await _context.AddRangeAsync(Students);
// await _context.SaveChangesAsync();

// foreach (var student in Students)
// {
//     Console.WriteLine($"The Student Id : ${student.Id}");
// }
#endregion

#region Make Enrollment
// var StudentId = 1007;
// var CourseId = 1000;

// var StudentExists = await _context.Students.FindAsync(StudentId);
// var CoursesExists = await _context.Courses.FindAsync(CourseId);

// if (StudentExists == null)
// {
//     Console.WriteLine("Enrollment Refused : the Student does not exist");
// }
// else if (CoursesExists == null)
// {
//     Console.WriteLine("Enrollment Refused : the Course does not exist");
// }
// else if (await _context.Enrollments.AnyAsync(e => e.StudentId == StudentId && e.CourseId == CourseId))
// {
//     Console.WriteLine("Enrollment Refused : the Enrolment already exists");
// }
// else
// {
//     await _context.Enrollments.AddAsync(new Enrollment
//     {
//         EnrollDate = new DateTime(2024, 1, 15),
//         Progress = 100m,
//         Status = Status.Completed,
//         FinalGrade = 100m,
//         CourseId = CourseId,
//         StudentId = StudentId
//     });
//     await _context.SaveChangesAsync();
//     Console.WriteLine("The Enrollment Added Successfully");
// }
#endregion

#region read Course
// var CourseId = 1004;
// var Title = "Web Development";

// var getCourseByID = await _context.Courses.FindAsync(CourseId);
// var getCourseByTitle = await _context.Courses.FirstOrDefaultAsync(x => x.Title == Title);

// if (getCourseByID == null)
// {
//     Console.WriteLine("The Course Does not Exist By Id", CourseId);
// }
// else if (getCourseByTitle == null)
// {
//     Console.WriteLine("The Course Does not Exist By Id", Title);
// }
// else
// {
//     Console.WriteLine($"The Course ExistBy ID ${getCourseByID.Id}");
//     Console.WriteLine($"The Course ExistBy Title ${getCourseByTitle.Id}");
// }
#endregion

#region filter Courses
// var courses = await _context.Courses.Where(c => c.Price >= 40 && c.Price <= 55).OrderByDescending(x => x.Price).Select(c => new
// {
//     c.Title,
//     c.Level,
//     c.Price
// }).ToListAsync();

// if (courses.Count() == 0)
// {
//     Console.WriteLine("There is no data found");
// }
// else
// {
//     foreach (var x in courses)
//     {
//         Console.WriteLine($"{x.Title},--- ${x.Level} --- ${x.Price}");
//     }
// }
#endregion

#region The SubCategory Levels
// var Category = "Programming";

// var GetTheCategory = await _context.Categories.FirstOrDefaultAsync(x => x.Name == Category);

// if (GetTheCategory == null)
// {
//     Console.WriteLine("The Category is not giving");
// }
// else
// {
//     var SubCategory = await _context.Categories.Where(x => x.ParentID == GetTheCategory.ID).ToListAsync();

//     foreach (var n in SubCategory)
//     {
//         Console.WriteLine($"{Category} ==> {n.Name}");
//     }
// }
#endregion

#region Course Roaster
// int courseId = 1001;

// var studentIds = await _context.Enrollments
//     .Where(e => e.CourseId == courseId)
//     .Select(e => e.StudentId)
//     .ToListAsync();

// Console.WriteLine($"Students enrolled in course {courseId}: {studentIds.Count}");

// var students = await _context.Students
//     .Where(s => studentIds.Contains(s.Id))
//     .OrderBy(s => s.FullName)
//     .Select(s => s.FullName)
//     .ToListAsync();

// foreach (var name in students)
//     Console.WriteLine($"- {name}");
#endregion

#region Update Price
// int courseId = 1001;
// decimal newPrice = 89.99m;

// var course = await _context.Courses.FindAsync(courseId);

// if (course is null)
// {
//     Console.WriteLine($"Course {courseId} does not exist.");
// }
// else if (newPrice < 0)
// {
//     Console.WriteLine("Price cannot be negative.");
// }
// else
// {
//     course.Price = newPrice;

//     await _context.SaveChangesAsync();

//     Console.WriteLine($"price changed to ${course.Price}.");
// }
#endregion

#region Update Progress
// var courseID = 1000;
// var StudentID = 1001;

// var findEnrollment = await _context.Enrollments.FindAsync(courseID, StudentID);

// if (findEnrollment == null)
// {
//     Console.WriteLine("The Enrollment does not Exist");
// }

// var input = Console.ReadLine();
// int.TryParse(input, out int Progress);
// if (Progress < 0 || Progress > 100)
// {
//     Console.WriteLine("The input is Invalid");
// }
// else
// {
//     findEnrollment.Progress = Progress;
//     if (Progress == 100)
//     {
//         findEnrollment.Status = Status.Completed;
//     }
//     await _context.SaveChangesAsync();
// }
#endregion

#region Update Course Date and State
// var CourseID = 1003;

// var getTheCourse = await _context.Courses.FindAsync(CourseID);

// if (getTheCourse == null)
// {
//     Console.WriteLine("There is no courses Existing");
// }

// getTheCourse.PublishDate = DateTime.Now;
// getTheCourse.IsPublished = !getTheCourse.IsPublished;

// await _context.SaveChangesAsync();

#endregion

#region Remove The Enrollment
// var courseID = 1002;
// var StudentID = 1002;

// var Enrollment = await _context.Enrollments.FindAsync(StudentID, courseID);

// if (Enrollment == null)
// {
//     Console.WriteLine("Enrollment does not Exist");
// }

// else
// {
//     _context.Remove(Enrollment);
//     await _context.SaveChangesAsync();
//     Console.WriteLine("Record Removed");
// }
#endregion

#region RemoveCategory
var CategoryID = 1000;
var Category = await _context.Categories.FindAsync(CategoryID);
if (Category == null)
{
    Console.WriteLine("the Category does not Exist");
}
else
{
    try
    {
        _context.Categories.Remove(Category);
        await _context.SaveChangesAsync();
    }
    catch (DbUpdateException err)
    {
        Console.WriteLine($"The error Statement : {err}");
    }
    //* This Shows the Error
}

//* The Safe version
var IsParent = await _context.Categories.AnyAsync(x => x.ParentID == CategoryID);
if (IsParent)
{
    Console.WriteLine("Can not Remove the Category because there is sub Categories");
}
else
{
    _context.Categories.Remove(Category);
    await _context.SaveChangesAsync();
}
#endregion

#region RemoveCourse
// int courseId = 1002;

// var course = await _context.Courses.FindAsync(courseId);

// if (course is null)
// {
//     Console.WriteLine($"Course {courseId} does not exist.");
//     return;
// }

// int before = await _context.Enrollments.CountAsync(e => e.CourseId == courseId);
// Console.WriteLine($"Enrollments before delete: {before}");

// _context.Courses.Remove(course);
// await _context.SaveChangesAsync();

// int after = await _context.Enrollments.CountAsync(e => e.CourseId == courseId);
// Console.WriteLine($"Enrollments after delete: {after}");

//! The Enrollment will be deleted because the Delete Behavior we have is Cascade which is gonna delete any related data in the enrollment table
#endregion

#region Update the prices

var affected = await _context.Courses.Where(x => x.IsPublished)
                    .ExecuteUpdateAsync(s => s.SetProperty(p => p.Price, p => p.Price * 1.1m));
Console.WriteLine(affected);
#endregion