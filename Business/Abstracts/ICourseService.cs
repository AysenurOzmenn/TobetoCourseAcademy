using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IDataResult<List<Course>> GetAllByCategoryId(int id);
        IDataResult<List<CourseDetailDto>> GetCourseDetails();
        IDataResult<Course> GetById(int courseId);
        IResult Add(Course course);
        IResult Update(Course course);
        IResult Delete(Course course);
    }
}
