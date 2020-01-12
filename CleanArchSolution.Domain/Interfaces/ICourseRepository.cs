using CleanArchSolution.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchSolution.Domain.Interfaces
{
   public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();

    }
}
