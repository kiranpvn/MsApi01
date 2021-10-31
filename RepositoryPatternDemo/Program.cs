using System;
namespace RepositoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDB context = null;
            
            context= new EmployeeDB(new SqlEmployeeRepository());
            Console.WriteLine(context.GetSource()) ;
            foreach ( EmpModel e in context.GetEmployees())
                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");   

            context = new EmployeeDB(new InMemoryEmployeeRepository());
            Console.WriteLine(context.GetSource());
            foreach (EmpModel e in context.GetEmployees())
                Console.WriteLine($"{e.Id} {e.EName} {e.Job} {e.Salary}");
        }
    }
}
