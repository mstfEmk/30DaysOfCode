using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13AbstractClasses
{
    abstract class Book
    {
        protected string title;
        protected string author;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public abstract void display();

    }

    class MyBook : Book
    {
        private int price;
        public MyBook(string title, string author, int price) : base(title, author)
        {
            this.price = price;
        }

        public override void display()
        {
            Console.WriteLine("Title: {0}", this.title);
            Console.WriteLine("Author: {0}", this.author);
            Console.WriteLine("Price: {0}", this.price);
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            MyBook myBook = new MyBook("The Alchemist", "Paulo Coelho", 248);
            myBook.display();
        }
    }
}
