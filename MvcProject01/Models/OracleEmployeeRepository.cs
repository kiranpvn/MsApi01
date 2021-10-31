using MvcProject01.Models;
using System.Collections.Generic;
namespace MvcProject01.Models
{
    class OracleEmployeeRepository : IEmployeeRepository
    {
        public List<EmpModel> Employees { get; set; }
        public OracleEmployeeRepository()
        {
            this.Employees = new List<EmpModel> {
            new EmpModel { Id=3001,EName="Anirudh",Job="Developer",Salary=15000},
            new EmpModel { Id = 3002, EName = "Bhuvana", Job = "Programmer", Salary = 12500 },
            new EmpModel { Id = 3003, EName = "David sekhar", Job = "Trainer", Salary = 31500 }
            };
        }
        public List<EmpModel> GetAllEmployees()
        {
            return Employees;
        }

        public string SourceDB()
        {
            return "oracle";
        }
    }
}
