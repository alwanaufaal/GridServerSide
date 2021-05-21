using GridServerSide.Models;
using GridServerSide.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace GridServerSide.Controllers
{
    public class StudentController : Controller
    {
        IStudent _IStudent;

        public StudentController(IStudent IStudent)
        {
            _IStudent = IStudent;
        }

        public IActionResult Student(int? page = 1)
        {
            StudentPaging studentPaging = new StudentPaging();
            if (page < 0)
            {
                page = 1;
            }

            var pageIndex = (page ?? 1) - 1;
            var pageSize = 5;
            int totalStudent = _IStudent.GetStudentCount();
            var students = _IStudent.StudentPaging(page, pageSize).ToList();
            var studentPagedList = new StaticPagedList<Student>(students, pageIndex + 1, pageSize, totalStudent);
            studentPaging.Students = studentPagedList;
            studentPaging.pageSize = page;

            return View(studentPaging);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
