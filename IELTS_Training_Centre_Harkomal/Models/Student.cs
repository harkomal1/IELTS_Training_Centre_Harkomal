using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IELTS_Training_Centre_Harkomal.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
    }
}
