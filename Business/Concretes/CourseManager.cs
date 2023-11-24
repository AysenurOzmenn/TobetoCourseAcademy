using Business.Abstracts;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        [ValidationAspect(typeof(CourseValidator))]
        public IResult Add(Course course)
        {
             //business codes
             _courseDal.Add(course);
            return new SuccessResult(Messages.CourseAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.CourseDeleted);
        }

        public IDataResult<List<Course>> GetAll()
        {
            if (DateTime.Now.Hour == 1)
            {
                return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),Messages.CourseListed);
        }

        public IDataResult<List<Course>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.CategoryId == id));
        }

        public IDataResult<Course> GetById(int courseId)
        {
            return new SuccessDataResult<Course>(_courseDal.Get(c => c.Id == courseId));
        }

        public IDataResult<List<CourseDetailDto>> GetCourseDetails()
        {
            //
            //if (DateTime.Now.Hour == 12)
            //{
            //    return new ErrorDataResult<List<CourseDetailDto>>(Messages.MaintenanceTime);
            //}

            return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails());
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.CourseUpdated);
        }
    }
}
