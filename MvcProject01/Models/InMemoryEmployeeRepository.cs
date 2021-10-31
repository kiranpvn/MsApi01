using MvcProject01.Models;
using System.Collections.Generic;
namespace MvcProject01.Models
{
    class InMemoryEmployeeRepository : IEmployeeRepository
    {
        public List<EmpModel> Employees { get; set; }
        public InMemoryEmployeeRepository()
        {
            this.Employees = new List<EmpModel> {
            new EmpModel { Id=2001,EName="Arvind",Job="Developer",Salary=15000},
            new EmpModel { Id = 2002, EName = "Bhanu", Job = "Programmer", Salary = 12500 },
            new EmpModel { Id = 2003, EName = "Chandra Sekhar", Job = "Trainer", Salary = 31500 }
            };
        }
        public List<EmpModel> GetAllEmployees()
        {
            return Employees;
        }

        public string SourceDB()
        {
            return "inmemory";
        }
    }
}
