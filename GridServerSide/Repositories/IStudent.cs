using GridServerSide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GridServerSide.Repositories
{
    public interface IStudent
    {
        int GetStudentCount();
        List<Student> StudentPaging(int? page, int pageSize);
    }
}
