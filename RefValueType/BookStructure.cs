using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValueType
{
    struct Book
    {
        private int bookId;
        private string bookName;
        private string Author;
        private float price;

       public Book(int id,string nm,string au,float pr)
        {
            bookId = id;
            bookName = nm;
            Author = au;
            price = pr;
        }

        public void Display()
        {
            Console.WriteLine("********** Book Information *****************");
            Console.WriteLine("Book ID : "+bookId);
            Console.WriteLine("Book Name : "+bookName);
            Console.WriteLine("Author : "+Author);
            Console.WriteLine("Price : "+price);
        }
    }
    internal class BookStructure
    {
        public static void Main1(string[] args)
        {
            Book[] books = new Book[3];
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine("Enter Book ID :");
                int bid=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Book Name : ");
                string bname = Console.ReadLine();
                Console.WriteLine("Enter Author Name :  ");
                string au=Console.ReadLine();
                Console.WriteLine("Enter Price : ");
                float p=float.Parse(Console.ReadLine());

                books[i]= new Book (bid, bname, au, p);

            }

            foreach(Book b in books)
            {
                b.Display();
            }
        }
    }
}
