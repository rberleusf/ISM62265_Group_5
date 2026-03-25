using System;
using System.Collections.Generic;
using System.Text;

namespace Competition2.Models
{
    public class Student : People
    { 

        public string MajorName { get; set; }
        public string GraduationYear { get; set; }

        public Student(string name, string email, string id, string majorName, string graduationYear) : base()
        {
            Name = name;
            Email = email;
            Id = id;
            MajorName = majorName;
            GraduationYear = graduationYear;
        }
    }
}
