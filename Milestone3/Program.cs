using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone3
{
    class Program
    {
        static void Main(string[] args)
        {
            //test the invManager
            InvManager manager = new InvManager();
            //make a product to add
            Product p = new Product();
            p.name = "Silly Putty";
            p.quantity = 143;
            p.price = 2.29;
            p.prodId = "123-sdfg";

            //add p to the manager
            manager.addItem(p);

            Product c = new Product();
            c.name = "Cards";
            c.quantity = 140;
            c.price = 2.25;
            c.prodId = "124-sdfg";

            manager.addItem(c);

            manager.restockItem(c);

            Console.WriteLine(c);

            manager.displayItems(manager);

            Product target = manager.findByIdOrName("123-sdfg","Silly Putty");
            if(target == null)
            {
                System.Console.WriteLine("Product with id and name: " + target + " is not there");
            }
            else
            {
                System.Console.WriteLine(target);
            }
        }
    }
    class Product
    {
        public string name { set; get; }
        public int quantity { set; get; }
        public double price { set; get; }
        public string prodId { set; get; }
        public Product()
        {
            name = "";
            quantity = 0;
            price = 0;
            prodId = "";
        }
        public override string ToString()
        {
            return "Name: " + name + ", Quantity: " + quantity + ", Price: $" + price + ",Id: " + prodId;
        }
    }
}
