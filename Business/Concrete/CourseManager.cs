﻿using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;

        // Dependency injection
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
            Console.WriteLine("Course added successfully");
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
            Console.WriteLine("Course deleted successfully.");
        }

        public List<Course> GetAll()
        {
            // Business codes
            // Validation
            // Authorization
            // ...
            return _courseDal.GetAll();
        }

        public List<Course> GetByCategory(int categoryId)
        {
            return _courseDal.GetByCategory(categoryId);
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public List<Course> GetByInstructor(int instructorId)
        {
            return _courseDal.GetByInstructor(instructorId);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
            Console.WriteLine("Course updated successfully.");
        }
    }
}
