using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreApp01
{
    [Table("tblDepartments")]
    public class Department
    {
        [Key]
        public int DId { get; set; }
        public string DName { get; set; }
        public string Location { get; set; }
        public List<Employee> Employee{ get; set; }
    }
}
