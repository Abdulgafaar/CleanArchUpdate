using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchSolution.Domain.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
