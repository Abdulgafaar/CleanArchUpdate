using CleanArchSolution.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchSolution.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
