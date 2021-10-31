using System.Collections.Generic;
namespace  MvcProject01.Models
{
    public interface IEmployeeRepository
    {
        List<EmpModel> GetAllEmployees();
        string SourceDB();
    }
}
