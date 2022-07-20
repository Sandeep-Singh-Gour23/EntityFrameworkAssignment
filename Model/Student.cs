using System;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkAssignment.Model
{
    public class Student
    {
        [Key] 
        public Guid id { get; set; }

        [Required]  
        public string name { get; set; }
        public string className { get; set; }

        public string rollNumber { get; set; }
        
        public int yearOfEnrollment { get; set; }
    }
}
