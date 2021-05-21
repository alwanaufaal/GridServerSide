using Dapper;
using GridServerSide.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace GridServerSide.Repositories
{
    public class StudentService : IStudent
    {
        public int GetStudentCount()
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings.Value))
            {
                var param = new DynamicParameters();
                var data = con.Query<int>("GetStudentCount", param, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();

                return data;
            }
        }

        public List<Student> StudentPaging(int? pageNumber, int pageSize)
        {
            using (SqlConnection con = new SqlConnection(ConnectionStrings.Value))
            {
                var param = new DynamicParameters();
                param.Add("@PageNumber", pageNumber);
                param.Add("@PageSize", pageSize);
                var data = con.Query<Student>("StudentPaging", param, commandType: System.Data.CommandType.StoredProcedure).ToList();

                return data;
            }
        }
    }
}
