using System;
using System.Collections.Generic;
using System.Text;

namespace Competition2.Models
{
    public class Library
    { 
        public List<People> DisplayPatrons { get; set; } = new List<People>();
        public List<Book> DisplayBooks { get; set; } = new List<Book>();

        public void AddPatron(People patron)
        {
            DisplayPatrons.Add(patron);
        }   

        public void AddBook(Book book)
        {
            DisplayBooks.Add(book);
        }

        public void BorrowBook(People patron, Book book)
        {
            if (book.AvailableCopies > 0)
            {
                book.AvailableCopies--;
                Console.WriteLine($"{patron.Name} borrowed '{book.Title}'.");
            }
            else
            {
                Console.WriteLine($"Sorry, '{book.Title}' is currently unavailable.");
            }
        }

    }

}
