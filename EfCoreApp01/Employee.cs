using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreApp01
{
    [Table("tblEmployees")]
   public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
        public Department DId { get; set; }

    }
}
