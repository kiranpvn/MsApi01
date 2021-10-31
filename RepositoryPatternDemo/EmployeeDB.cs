using System.Collections.Generic;
namespace RepositoryPatternDemo
{
    class EmployeeDB
    {
        public IEmployeeRepository source  { get; set; }
        public EmployeeDB(IEmployeeRepository source)
        {
            this.source = source;
        }
        public List<EmpModel> GetEmployees() => source.GetAllEmployees();
        public string GetSource() => source.SourceDB();
    }
}
