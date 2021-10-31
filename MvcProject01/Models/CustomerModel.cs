using System;
using System.Linq;
using System.Threading.Tasks;

namespace MvcProject01.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string CName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
    }
}
