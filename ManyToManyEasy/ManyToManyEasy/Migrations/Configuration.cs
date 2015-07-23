namespace ManyToManyEasy.Migrations
{
    using ManyToManyEasy.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManyToManyEasy.Models.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManyToManyEasy.Models.SchoolDbContext context)
        {
            //Seed Students
            var students = new Student[]
            {
                new Student { LastName = "Brittain", FirstName = "Nick" },
                new Student { LastName = "Mathias", FirstName = "Jason" }
            };

            context.Students.AddOrUpdate(s => new { s.FirstName, s.LastName }, students);
            context.SaveChanges();

            //Seed Courses
            var courses = new Course[]
            {
                new Course { Code = "MATH100", Name ="Intro to Math" },
                new Course { Code = "CSHARP100", Name ="Intro to C#" },
                new Course { Code = "CSHARP200", Name ="Adv C#" }
            };

            context.Courses.AddOrUpdate(c => c.Code, courses);
            context.SaveChanges();


            var nick = context.Students.FirstOrDefault(s => s.FirstName == "Nick");
            var jason = context.Students.FirstOrDefault(s => s.FirstName == "Jason");
         
            StudentCourse sc = new StudentCourse
            {
                CourseId = courses[0].Id,
                StudentId = jason.Id
            };

            context.StudentCourses.Add(sc);

            if (!nick.Courses.Any(c => c.CourseId == courses[0].Id))
            {
                nick.Courses.Add(new StudentCourse
                {
                    CourseId = courses[0].Id
                });
            }

            if (!nick.Courses.Any(c => c.CourseId == courses[1].Id))
            {
                nick.Courses.Add(new StudentCourse
                {
                    CourseId = courses[1].Id
                });
            }

            StudentCourse course = nick.Courses.FirstOrDefault(c => c.Course.Code == "MATH100");
            course.Grade = 90;
            
        }
    }
}
