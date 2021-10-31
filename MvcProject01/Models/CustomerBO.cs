using System.Collections.Generic;
using System.Linq;
namespace MvcProject01.Models
{
    public class CustomerBO
    {
        public List<CustomerModel> Customers{ get; set; }
        public CustomerBO()
        {
            Customers = new List<CustomerModel> { 
                new CustomerModel{Id=1001,CName="Kiran",Email="kiran@gmail.com",City="Hyderabad",Mobile="9010894993"},
                new CustomerModel{Id=1002,CName="Anil",Email="ani@gmail.com",City="Bengaluru",Mobile="9090909090"}
            };
        }
        public List<CustomerModel> GetCustomers() => Customers;
        public CustomerModel GetCustomerById(int id) => Customers.Single(x => x.Id == id);
        public void AddCustomer(CustomerModel c) => Customers.Add(c);
        public void EditCustomer(CustomerModel c, int id) => Customers[Customers.FindIndex(x => x.Id == id)] = c;
        public void DeleteCustomer(int id) => Customers.Remove(Customers.Single(x => x.Id == id));
    }
}
