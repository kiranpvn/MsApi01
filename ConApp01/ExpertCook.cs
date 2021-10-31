using System;
namespace ConApp01
{
    class ExpertCook
    {
        IItem item;
        public ExpertCook(IItem item)
        {
            this.item = item;
        }
        public void Prepare()
        {
            item.GetReceipe();
            if (this.item == null)
                Console.WriteLine("Dish not available, sorry");
            else
                Console.WriteLine(item.Cook());
        }
    }
}

