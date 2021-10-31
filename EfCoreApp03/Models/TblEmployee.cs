using System;
using System.Collections.Generic;

#nullable disable

namespace EfCoreApp03.Models
{
    public partial class TblEmployee
    {
        public int Id { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int? Salary { get; set; }
    }
}
