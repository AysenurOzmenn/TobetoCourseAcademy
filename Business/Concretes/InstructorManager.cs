using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public IResult Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
            return new SuccessResult(Messages.InstructorAdded);
        }

        public IResult Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
            return new SuccessResult(Messages.InstructorDeleted);
        }

        public IDataResult<List<Instructor>> GetAll()
        {
            return new SuccessDataResult<List<Instructor>>(_instructorDal.GetAll(),Messages.InstructorListed);
        }

        public IDataResult<Instructor> GetById(int id)
        {
            return new SuccessDataResult<Instructor>(_instructorDal.Get(i => i.Id == id));
        }

        public IResult Update(Instructor instructor)
        {
           _instructorDal.Update(instructor);
            return new SuccessResult(Messages.InstructorUpdated);
        }

    }
}
