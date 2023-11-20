using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        List<Course> _courses;
        public InMemoryCourseDal()
        {   //Oracle, Sql Server, Postgres, MongoDb
            _courses = new List<Course>()
            {
                new Course{Id=1, CategoryId = 1, InstructorId=1, Name = ".NET",Description = ".NET Eğitimi", Price=0},
                new Course{Id=2, CategoryId = 1, InstructorId=1, Name = "Java",Description = "Java Eğitimi", Price = 0},
                new Course{Id=3, CategoryId = 2, InstructorId=2, Name = "Python",Description = "Python Eğitimi", Price = 0},
                new Course{Id=4, CategoryId = 1, InstructorId=1, Name = "React",Description = "React Eğitimi", Price = 0},
                new Course{Id=5, CategoryId = 1, InstructorId=1, Name = "JavaScript",Description = "JavaScript Eğitimi", Price = 0},
                new Course{Id=6, CategoryId = 1, InstructorId=1, Name = "C# + Angular",Description = "C# + Angular Eğitimi", Price = 0},
                new Course{Id=7, CategoryId = 1, InstructorId=1, Name = "Java + React",Description = "Java + React Eğitimi", Price = 0}
            };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseToDelete = _courses.SingleOrDefault(c => c.Id == course.Id);

            _courses.Remove(courseToDelete);
        }

        public Course Get(Expression<Func<Course, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            return _courses;
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.SingleOrDefault(c => c.Id == course.Id);
            courseToUpdate.Name = course.Name;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
            courseToUpdate.Description = course.Description;
            courseToUpdate.Price = course.Price;
        }
        public List<Course> GetAll()
        {
            return _courses;
        }

        public List<CourseDetailDto> GetCourseDetails()
        {
            throw new NotImplementedException();
        }
    }
}
