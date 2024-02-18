using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICourseDal : IEntityDal<Course>
    { 
        List<Course> GetByCategory(int categoryId);
        List<Course> GetByInstructor(int instructorId);

    }
}
