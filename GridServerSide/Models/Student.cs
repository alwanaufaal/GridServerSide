using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace GridServerSide.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentGPA { get; set; }
    }

    public class StudentPaging
    {
        public int? pageSize;
        public StaticPagedList<Student> Students { get; set; }
    }
}
