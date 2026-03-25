using Competition2.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

var library = new Library();

// Add some books to the library

library.DisplayBooks.Add(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
library.DisplayBooks.Add(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
library.DisplayBooks.Add(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));

Console.WriteLine("Books In Library");
foreach (var book in library.DisplayBooks)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
}

Console.WriteLine("Books After Borrowing");
Console.WriteLine("Books In Library");
foreach (var book in library.DisplayBooks)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
}