using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        private List<Course> _courses;

        public InMemoryCourseDal()
        {
            _courses =
            [
                new Course { CourseId = 1, CategoryId = 1, InstructorId = 1, CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)", CourseDescription = "NET 6 üzerinde, clean architecture, CQRS, event güdümlü geliştirme, birim testleri, code first geliştirme, docker ve çok daha fazlasını içeren 2 aylık ileri bir kamp sizi bekliyor. Yine ücretsiz.", CoursePrice = 0 },
                new Course { CourseId = 2, CategoryId = 1, InstructorId = 1, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JAVA)", CourseDescription = "Java 16 ile backend web development kampı. Java 16, Spring Boot, AOP, Microservices, RabbitMQ, API Gateway gibi konuları içeren 2 aylık ileri bir kamp sizi bekliyor. Ücretsiz.", CoursePrice = 0 },
                new Course { CourseId = 3, CategoryId = 1, InstructorId = 2, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (PYTHON)", CourseDescription = "Python 3.9 ile backend web development kampı. Python 3.9, Flask, AOP, Microservices, RabbitMQ, API Gateway gibi konuları içeren 2 aylık ileri bir kamp sizi bekliyor. Ücretsiz.", CoursePrice = 0 },
                new Course { CourseId = 4, CategoryId = 1, InstructorId = 2, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (REACT)", CourseDescription = "React 17 ile frontend web development kampı. React 17, Redux, Router, Axios gibi konuları içeren 2 aylık ileri bir kamp sizi bekliyor. Ücretsiz.", CoursePrice = 0 },
                new Course { CourseId = 5, CategoryId = 1, InstructorId = 1, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (ANGULAR)", CourseDescription = "Angular 12 ile frontend web development kampı. Angular 12, RxJS, Router, HttpClient gibi konuları içeren 2 aylık ileri bir kamp sizi bekliyor. Ücretsiz.", CoursePrice = 0 }
            ];
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseToDelete = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            _courses.Remove(courseToDelete);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public List<Course> GetByCategory(int categoryId)
        {
            return _courses.Where(c => c.CategoryId == categoryId).ToList();
        }

        public Course GetById(int id)
        {
            return _courses.SingleOrDefault(c => c.CourseId == id);
        }

        public List<Course> GetByInstructor(int instructorId)
        {
            return _courses.Where(c => c.InstructorId == instructorId).ToList();
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
            courseToUpdate.CourseName = course.CourseName;
            courseToUpdate.CourseDescription = course.CourseDescription;
            courseToUpdate.CoursePrice = course.CoursePrice;
        }
    }
}
