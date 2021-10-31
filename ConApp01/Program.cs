using System;
namespace ConApp01
{
    interface IDal
    {
        void ConnectToDB();
        void AccessData();
    }
    class SqlDal : IDal
    {
        public void AccessData()
        {
            Console.WriteLine("Customer data fetched from Sql server");
        }

        public void ConnectToDB()
        {
            Console.WriteLine("Code to connect to Sql Server");
        }
    }
    class OraDal : IDal
    {
        public void AccessData()
        {
            Console.WriteLine("Customer data fetched from Oracle");
        }

        public void ConnectToDB()
        {
            Console.WriteLine("Code to connect to Oracle");
        }
    }
    class Customer
    {
        IDal dal;
        public Customer(IDal dal)
        {
            this.dal = dal;
        }
        public void GetData()
        {
            dal.ConnectToDB();
            dal.AccessData();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer data1 = new Customer(new SqlDal());
            data1.GetData();

            Customer data2 = new Customer(new OraDal());
            data2.GetData();
        }
    }
}

