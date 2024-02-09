using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_product
{
    class Customer
    {
        public string customerName = "";
        public string customerAddress = "";
        public string customerContact = "";

        public Customer(string n,string a,string c)
        {
            this.customerName = n;
            this.customerAddress = a;
            this.customerContact = c;
        }
        public List<Product> products = new List<Product>();
        public List<Product> getallProducts()
        {
            return products;
        }

        public void addProduct (Product p)
        {
            products.Add(p);
        }
    }

    class Product
    {
        public string name = "";
        public string category = "";
        public int price;

        public Product(string name,string category,int price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }

        public float calculateTax()
        {
            float tax = price * 0.05F;
            return tax;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Mohammad Zaid", "Lahore", "0986");
            Customer c2 = new Customer("Faraz", "Karachi", "123");

            Product p1 = new Product("Iphone", "Electronics", 2000);
            c1.addProduct(p1);

            Product p2 = new Product("Laptop", "Electronic", 25000);
            c1.addProduct(p2);
    
            foreach(Product p in c1.getallProducts())
            {
                Console.WriteLine(c2.customerName + "," + c2.customerAddress + "," + c2.customerContact);
                Console.WriteLine(p.name + "," + p.category + "," + p.price + "," + p.calculateTax());
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
