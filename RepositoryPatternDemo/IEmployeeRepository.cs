using System.Collections.Generic;
namespace RepositoryPatternDemo
{
    interface IEmployeeRepository
    {
        List<EmpModel> GetAllEmployees();
        string SourceDB();
    }
}
