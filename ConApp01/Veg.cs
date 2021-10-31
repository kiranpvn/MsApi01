using System;
namespace ConApp01
{
    class Veg : IItem
    {
        private string dish;
        public Veg(string dish)
        {
            this.dish = dish;
        }
        public string Cook()
        {
            return "Veg " + dish + " cooked, ready and start eating";
        }
        public void GetReceipe()
        {
            Console.WriteLine($"Receipt to prepare the dish {dish} ");
        }
    }
}

