using System;

namespace bookStore
{
    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.SetTrans();
            book1.SetId(1);
            book1.SetTitle("Granite Moutain");
            book1.SetAuthor("Brendan McDonough");

            book book2 = new book();
            book2.SetTrans();
            Console.WriteLine("Enter the Id of the book: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the Title of the book: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Enter the Author of the book: ");
            book2.SetAuthor(Console.ReadLine());

            book book3 = new book(10, "Insomnia", "Stephen King");
            book3.SetTrans();

            Console.WriteLine("Please enter the Id of your book");
            int tempId = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Title of your book");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the Author of your book");
            string tempAuthor = Console.ReadLine();
            book book4 = new book(tempId, tempTitle, tempAuthor);
            book4.SetTrans();

            Console.WriteLine($"The number of transactions is {book4.GetTrans}");
            displaybook(book1);
            displaybook(book2);
            displaybook(book3);
            displaybook(book4);

        }
        private static void displaybook(book book)
        {
            Console.WriteLine("Book Id: " + book.GetId());
            Console.WriteLine("Book Title: " + book.GetTitle());
            Console.WriteLine("Book Author: " + book.GetAuthor());
            Console.WriteLine();
        }


    }
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;

        //Default Constructor
        public book()
        {
            _Id = 0;
            _Title = String.Empty;
            _Author = String.Empty;
            _transactions = 0;
        }
        public book(int Id, string Title, string Author)
        {
            _Id = Id;
            _Title = Title;
            _Author = Author;
        }
        //Get and Set for Id
        public int GetId()
        {
            return _Id;
        }
        public void SetId(int Id)
        {
            _Id = Id;
        }
        //Get and Set for Title
        public string GetTitle()
        {
            return _Title;
        }
        public void SetTitle(string Title)
        {
            _Title = Title;
        }
        //Get and Set for Author
        public string GetAuthor()
        {
            return _Author;
        }
        public void SetAuthor(string Author)
        {
            _Author = Author;
        }
        //Get and Set for Transactions
        public int GetTrans()
        {
            return _transactions;
        }
        public void SetTrans()
        {
            
            _transactions++;
        }
    }
}


