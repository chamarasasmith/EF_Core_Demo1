using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EF_Core_Demo1.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public int SchoolID { get; set; }
         
        public ICollection<Enrollment> Enrollments { get; set; }
        public School School { get; set; }
    }
}
