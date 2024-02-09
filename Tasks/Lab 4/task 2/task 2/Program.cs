using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        class Books
        {
            public string author;
            public int page;
            public string chapters;
            public int chpNumber;
            public int bookMark;
            public int price;

            public Books(string a,int p,string c,int cn,int b,int pr)
            {
                this.author = a;
                this.page = p;
                this.chapters = c;
                this.chpNumber = cn;
                this.bookMark = b;
                this.price = pr;
            }

            public string getChapter(int chap, int count)
            {
                string ans = "";
                int ch = chap;
                ch = count-1;

                for (int i = 0; i < count; i++)
                {
                    if (i == ch)
                    {
                        ans = chapters;
                    }
                }

                return ans;
            }

            public int getBookMark()
            {
                int bm = bookMark;
                return bm ;
            }

            public void setBookMark(int pageNum)
            {
                bookMark = pageNum;
                int bMark = bookMark;
                Console.WriteLine("Your new book mark is: {0}",bMark);
            }

            public int getBookPrice()
            {
                int bp = price;
                return bp;
            }

            public void setBookPrice(int newPrice)
            {
                price = newPrice;
                int bPrice = price;
                Console.WriteLine("Your new book mark is: {0}", bPrice);
            }

        }
        static void Main(string[] args)
        {
            List<Books> stud = new List<Books>();

            int op = 0;
            int count = 0;

            while(op != 7)
            {
                op = option();

                if (op == 1)
                {
                    Console.Clear();
                    stud.Add(librarybooks());
                    count++;
                }

                else if(op == 2)
                {
                    Console.Clear();

                    int c = 0;

                    Console.WriteLine("Enter chapter No.: ");
                    int chap = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Author name: ");
                    string atn = Console.ReadLine();

                    foreach (Books us in stud)
                    {
                        if (atn == us.author && chap == us.chpNumber)
                        {
                            string ans = us.getChapter(chap,count);
                            Console.WriteLine("The name of the book is: {0}", ans);
                            Console.ReadKey();
                        }
                    }
                    
                }

                else if (op == 3)
                {
                    Console.Clear();
                    int c = 0;
                    Console.WriteLine("Enter Author name: ");
                    string at = Console.ReadLine();

                    Console.WriteLine("Enter chapter name: ");
                    string chp = Console.ReadLine();

                    foreach( Books st in stud)
                    {
                        if(at == st.author && chp == st.chapters)
                        {
                            int bm = st.getBookMark();
                            Console.Write("Th book mark is: {0}", bm);
                            Console.ReadKey();
                        }
                        
                    }
                }

                else if(op == 4)
                {
                    Console.Clear();

                    int bm;

                    Console.WriteLine("Enter Author name: ");
                    string atn = Console.ReadLine();

                    Console.WriteLine("Enter chapter name: ");
                    string chp = Console.ReadLine();
                    

                    foreach (Books lib in stud)
                    {
                        if (atn == lib.author && chp == lib.chapters)
                        {
                            int bmark = lib.bookMark;
                            Console.WriteLine("Your old book mark is: {0}", bmark);


                            Console.WriteLine("Enter new Book mark: ");
                            bm = int.Parse(Console.ReadLine());

                            lib.setBookMark(bm);
                            Console.ReadKey();
                        }
                    }
                }

                else if (op == 5)
                {
                    Console.Clear();
                    int c = 0;
                    Console.WriteLine("Enter Author name: ");
                    string at = Console.ReadLine();

                    Console.WriteLine("Enter chapter name: ");
                    string chp = Console.ReadLine();

                    foreach (Books st in stud)
                    {
                        if (at == st.author && chp == st.chapters)
                        {
                            int bp = st.getBookPrice();
                            Console.Write("The price of Book is: {0}", bp);
                            Console.ReadKey();
                        }

                    }
                }

                else if (op == 6)
                {
                    Console.Clear();
                    int bp;

                    Console.WriteLine("Enter Author name: ");
                    string atn = Console.ReadLine();

                    Console.WriteLine("Enter chapter name: ");
                    string chp = Console.ReadLine();


                    foreach (Books lib in stud)
                    {
                        if (atn == lib.author && chp == lib.chapters)
                        {
                            int bprice = lib.price;
                            Console.WriteLine("Your old book mark is: {0}", bprice);


                            Console.WriteLine("Enter new Book Price: ");
                            bp = int.Parse(Console.ReadLine());

                            lib.setBookPrice(bp);
                            Console.ReadKey();
                        }
                    }
                }
                Console.Clear();
            }

        }

        static Books librarybooks()
        {
            //List<string> chp = new List<string>();

            Console.WriteLine("Enter the Author of Book: ");
            string aut = Console.ReadLine();

            Console.WriteLine("Enter the page No. of the Book: ");
            int pg = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the chapter Name of the book: ");
            string ch = Console.ReadLine();

            Console.WriteLine("Enter the chapter no. : ");
            int cnum = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the page No.of Book Mark: ");
            int bm = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price of the book: ");
            int pri = int.Parse(Console.ReadLine());

            Books obj = new Books(aut, pg, ch,cnum, bm, pri);

            return obj;
        }

        static int option()
        {
            int op;
            Console.WriteLine("Enter 1 for Add Books... ");
            Console.WriteLine("Enter 2 for View Chapter name... ");
            Console.WriteLine("Enter 3 for View Book Mark... ");
            Console.WriteLine("Enter 4 for Change Book Mark...");
            Console.WriteLine("Enter 5 for View Book Price...");
            Console.WriteLine("Enter 6 for Change Book Ptice...");
            Console.WriteLine("Enter 7 for Exit..."); 
            op = int.Parse(Console.ReadLine());
            return op;
        }
    }
}
