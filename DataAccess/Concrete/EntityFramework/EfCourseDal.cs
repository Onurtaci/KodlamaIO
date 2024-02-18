using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCourseDal : ICourseDal
    {
        public void Add(Course course)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course course)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Course> GetByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetByInstructor(int instructorId)
        {
            throw new NotImplementedException();
        }

        public void Update(Course course)
        {
            throw new NotImplementedException();
        }
    }
}
