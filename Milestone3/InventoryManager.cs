using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    class InvManager
    {
        //product list
        private List<Product> items;

        //constructer
        public InvManager()
        {
            //initialize the attributes
            items = new List<Product>();
        }

        public void addItem(Product item)
        {   
            items.Add(item);                  
        }
        public void removeItem(Product item)
        {
            items.Remove(item);
        }
        public Product findByIdOrName(string id, string name)
        {
            Product result = null;

            for(int i = 0; i < items.Count(); i++)
            {
                //does this product have the same id as a param id?
                if (items[i].prodId == id || items[i].name == name)
                    result = items[i];
            }
            return result;
        }

        public void restockItem(Product item)
        {
            item.quantity = 500;
        }
        public void displayItems(InvManager manager)
        {
                Console.WriteLine(string.Join("\n", items));
        }
    }
}
