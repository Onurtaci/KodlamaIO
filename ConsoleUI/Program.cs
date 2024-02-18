using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using Entities.Concrete;

CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());
InstructorManager instructorManager = new InstructorManager(new InMemoryInstructorDal());

// List all courses, categories and instructors
Console.WriteLine("Courses:");
courseManager.GetAll().ForEach(course => Console.WriteLine(course.CourseName));

Console.WriteLine("\nCategories:");
categoryManager.GetAll().ForEach(category => Console.WriteLine(category.CategoryName));

Console.WriteLine("\nInstructors:");
instructorManager.GetAll().ForEach(instructor => Console.WriteLine(instructor.InstructorName));

// Get a course by category id
Console.WriteLine("\nCourses by Category 1:");
courseManager.GetByCategory(1).ForEach(course => Console.WriteLine(course.CourseName));

// Get a course by instructor id
Console.WriteLine("\nCourses by Instructor 1:");
courseManager.GetByInstructor(1).ForEach(course => Console.WriteLine(course.CourseName));

Console.WriteLine("\n");
// Update a course
courseManager.Update(new Course
{
    CourseId = 4,
    CategoryId = 1,
    InstructorId = 1,
    CourseDescription = "Angular 12 ile frontend web development kampı. Angular 12, RxJS, Router, HttpClient " +
    "gibi konuları içeren 2 aylık ileri bir kamp sizi bekliyor. Ücretsiz.",
    CoursePrice = 0
});

Console.WriteLine("\n");
// Add a new category
categoryManager.Add(new Category { CategoryId = 3, CategoryName = "IT & Software" });

Console.WriteLine("\n");
// Delete a instructor
Instructor instructor = new Instructor { InstructorId = 2, InstructorName = "Engin Demiroğ" };
instructorManager.Delete(instructor);
