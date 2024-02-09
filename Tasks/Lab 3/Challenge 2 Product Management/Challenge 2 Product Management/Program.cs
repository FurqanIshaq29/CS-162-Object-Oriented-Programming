using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2_Product_Management
{
    class Program
    {
        class product
        {
            public string productName;
            public string productCategory;
            public int productPrice;
            public int stockQuantity;

            /*public product(string na, string ca, int pr, int st)
            {
                this.productName = na;
                this.productCategory = ca;
                this.productPrice = pr;
                this.stockQuantity = st;
            }*/

            public int menu()
            {
                int option;
                Console.WriteLine("Select one of the following options number...");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Highest Price Product");
                Console.WriteLine("4. Sales Taxes of Products");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Your Option");
                option = int.Parse(Console.ReadLine());
                return option;
            }

            public void topHeader()
            {
                Console.WriteLine("                                ************************************************");
                Console.WriteLine("                                *          PRODUCTS MANAGEMENT SYSTEM          *");
                Console.WriteLine("                                ************************************************");
            }
            public void clearScreen()
            {
                /*Console.ForegroundColor = ConsoleColor.DarkGreen;*/
                Console.WriteLine("Press Any Key to Continue...");
                Console.ReadKey();
                Console.Clear();
            }

        }
        static void Main(string[] args)
        {
            List<product> products = new List<product>();
            product abs = new product();


            Productinterface(products);
            Console.Read();
        }

        static void Productinterface(List<product> products)
        {
            product obj = new product();
            int productOption = 0;
            int c = 0;
            while (productOption != 5)
            {
                obj.topHeader();
                productOption = obj.menu();

                if (productOption == 1)
                {
                    Console.Clear();
                    obj.topHeader();
                    products.Add(addNewProducts());
                    c++;
                }

                else if(productOption == 2)
                {
                    Console.Clear();
                    obj.topHeader();
                    showProducts(products,c);

                }

                else if(productOption == 3)
                {
                    Console.Clear();
                    obj.topHeader();
                    findHighestPricedProduct(products, c);
                }

                else if(productOption == 4)
                {
                    Console.Clear();
                    obj.topHeader();
                }
                obj.clearScreen();
            }
        }

        static product addNewProducts()
        {
            product ad = new product();

            Console.WriteLine("Enter the name: ");
            ad.productName = Console.ReadLine();

            Console.WriteLine("Enter Product category: ");
            ad.productCategory = Console.ReadLine();

            Console.WriteLine("Enter product Price: ");
            ad.productPrice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Quantity you have: ");
            ad.stockQuantity = int.Parse(Console.ReadLine());

            return ad;
        }

        static void showProducts(List<product> pro , int count)
        {
            Console.Clear();

            int c = 0;

            for(int i = 0; i < count; i++)
            {
                if (pro[i].stockQuantity > 0)
                {
                    Console.WriteLine("Product Name: {0}    Product Category: {1}    Product Price: {2}    Product Quantity: {3}", pro[i].productName, pro[i].productCategory, pro[i].productPrice, pro[i].stockQuantity);
                    Console.ReadKey();
                }
                else
                {
                    c++;
                }
            }
            if(count == c)
            {
                Console.WriteLine("No Product Add Yet!!!");
            }
        }

        static void findHighestPricedProduct(List<product> pro, int count)
        {
            string n ="";
            string c = "";
            int s = 0;
            int largest = -1;

            int ct = 0;
            int ct2 = 0;

            int one, two;
            Console.WriteLine("1. Fruits Highest Price");
            Console.WriteLine("2. Grocery Highest Price");
            Console.WriteLine("Enter Your Option!!!");
            one = int.Parse(Console.ReadLine());

                if (one == 1)
                {
                    for (int i = 0; i < count; i++)
                    {
                        if (pro[i].productPrice > largest && (pro[i].productCategory == "fruit" || pro[i].productCategory == "Fruit"))
                        {
                            largest = pro[i].productPrice;
                            n = pro[i].productName;
                            c = pro[i].productCategory;
                            s = pro[i].stockQuantity;
                        }
                        else
                        {
                            ct++;
                        }
                    }
                    if (ct == count)
                    {
                        Console.Write("No Product Add Yet!!!");
                    }
                    else
                    {
                        Console.WriteLine("The Highest Priced Product is Below!");
                        Console.WriteLine("Product Name: {0}    Product Category: {1}    Product Price: {2}    Product Quantity: {3}", n, c, largest, s);
                    }
                }

                if (one == 2)
                {

                    for (int i = 0; i < count; i++)
                    {
                        if (pro[i].productPrice > largest && (pro[i].productCategory == "grocery" || pro[i].productCategory == "Grocery"))
                        {
                            largest = pro[i].productPrice;
                            n = pro[i].productName;
                            c = pro[i].productCategory;
                            s = pro[i].stockQuantity;
                        }
                        else
                        {
                            ct2++;
                        }
                    }
                    if (ct2 == count)
                    {
                        Console.Write("No Product Add Yet!!!");
                    }
                    else
                    {
                        Console.WriteLine("The Highest Priced Product is Below!");
                        Console.WriteLine("Product Name: {0}    Product Category: {1}    Product Price: {2}    Product Quantity: {3}", n, c, largest, s);
                    }
                }
            
            Console.ReadKey();

        }
    }
}
