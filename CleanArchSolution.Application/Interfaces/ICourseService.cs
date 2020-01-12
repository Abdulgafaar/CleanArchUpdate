using CleanArchSolution.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchSolution.Application.Interfaces
{
   public interface ICourseService
    {
        IEnumerable<CourseViewModel> GetCourses();
    }
}
