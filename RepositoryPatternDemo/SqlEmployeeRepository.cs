using System;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace MvcProject01.Models
{
    class SqlEmployeeRepository : IEmployeeRepository
    {
        public List<EmpModel> Employees { get; set; }
        public SqlEmployeeRepository()
        {
            SqlConnection cn = new SqlConnection("server=DESKTOP-DM30GHJ;user id=sa;password=welcome;database=EmpDB");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblEmployees", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            Employees = new List<EmpModel>();
            EmpModel e = new EmpModel();
            while (dr.Read())
            {
                e = new EmpModel()
                {
                    Id =Convert.ToInt32(dr[0]),
                    EName=dr[1].ToString(),
                    Job=dr[2].ToString(),
                    Salary=Convert.ToInt32(dr[3])
                };
                Employees.Add(e);
            }
            cmd.Dispose();  dr.Close();
        }
        public List<EmpModel> GetAllEmployees()
        {
            return Employees;
        }

        public string SourceDB()
        {
            return "Sql Server";
        }
    }
}
