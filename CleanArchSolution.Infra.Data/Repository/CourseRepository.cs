using CleanArchSolution.Domain.Interfaces;
using CleanArchSolution.Domain.Models;
using CleanArchSolution.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchSolution.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _myContext;

        public CourseRepository(UniversityDBContext myContext)
        {
            _myContext = myContext;
        }
        public IEnumerable<Course> GetCourses()
        {
            return _myContext.Courses;
        }
    }
}
