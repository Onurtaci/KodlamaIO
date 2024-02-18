using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryInstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors;

        public InMemoryInstructorDal()
        {
            _instructors =
            [
                new Instructor {InstructorId = 1, InstructorName = "Engin Demiroğ"},
                new Instructor {InstructorId = 2, InstructorName = "Halit Enes Kalaycı"}
            ];
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor instructorToDelete = _instructors.SingleOrDefault(i => i.InstructorId == instructor.InstructorId);
            _instructors.Remove(instructorToDelete);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            return _instructors.SingleOrDefault(i => i.InstructorId == id);
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructors.SingleOrDefault(i => i.InstructorId == instructor.InstructorId);
            instructorToUpdate.InstructorName = instructor.InstructorName;
        }
    }
}
