using System;
namespace ConApp01
{
    class NonVeg : IItem
    {
        private string dish;
        public NonVeg(string dish)
        {
            this.dish = dish;
        }
        public string Cook()
        {
            return "Non Veg " + dish + " cooked, ready and start eating";
        }

        public void GetReceipe()
        {
            Console.WriteLine($"Receipt to prepare the dish {dish} ");
        }
    }
}

