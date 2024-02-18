using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using Entities.Concrete;

CourseManager courseManager = new CourseManager(new InMemoryCourseDal());

courseManager.GetByInstructor(1).ForEach(course => Console.WriteLine(course.CourseName));