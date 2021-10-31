using System;
using System.Threading.Tasks;

namespace MvcProject01.Models
{
    //POCO Class
    public class StudentModel
    {
        public int Id { get; set; }
        public string SName { get; set; }
        public string Course { get; set; }
        public int Fee { get; set; }
    }
}

//Plain Old CLR Objects, the class containing public properties called as POCO Classes
//The object of this class can refers to database table row