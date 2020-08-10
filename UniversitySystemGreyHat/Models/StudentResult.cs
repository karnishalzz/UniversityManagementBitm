using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversitySystemGreyHat.Models
{
    public class StudentResult
    {
        public int StudentResultId { get; set; }
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public int GradeLetterId { get; set; }
    }
}