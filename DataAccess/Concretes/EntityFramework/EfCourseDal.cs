using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, CourseAcademyDbContext>, ICourseDal
    {
        public List<CourseDetailDto> GetCourseDetails()
        {
            using (CourseAcademyDbContext context = new CourseAcademyDbContext())
            {
                var result = from c in context.Course
                             join ct in context.Category
                             on c.CategoryId equals ct.Id
                             join i in context.Instructor
                             on c.InstructorId equals i.Id
                             select new CourseDetailDto 
                             { CourseId = c.Id, CategoryName = ct.Name, CourseName = c.Name, InstructorName = i.Name };
                return result.ToList();
            }
        }
    }
}
