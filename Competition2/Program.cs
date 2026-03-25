using Competition2.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

var library = new Library();

// Add some books to the library

library.DisplayBooks.Add(new Book("The Art of Data Strategy", "Liam Reynolds", "ISBN111", 4));
library.DisplayBooks.Add(new Book("Business Insights with AI", "Olivia Carter", "ISBN222", 3));
library.DisplayBooks.Add(new Book("Analytics in Action", "Nathan Brooks", "ISBN333", 6));

//Add some patrons
library.DisplayPatrons.Add(new Student("Akhil", "akhil@usf.edu", "S001", "Business Analytics", "2026"));
library.DisplayPatrons.Add(new Student("Sandeep", "sandeep@usf.edu", "S002", "Information Systems", "2025"));
library.DisplayPatrons.Add(new Staff("Grandon Gill", "grandon@usf.edu", "ST001", "Librarian", "Library Services"));

var Sandeep = library.DisplayPatrons[1];
var Akhil = library.DisplayPatrons[0];

var businessInsightsBook = library.DisplayBooks[1];
var analyticsAction = library.DisplayBooks[2];

Console.WriteLine("Books In Library:");
foreach (var book in library.DisplayBooks)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
}

Console.WriteLine("\nPatrons in Library:");
foreach (var patron in library.DisplayPatrons)
{
    Console.WriteLine($"Name: {patron.Name}, ID: {patron.Id}");
}

Console.WriteLine("");
Console.WriteLine("Borrowing Books...");
library.BorrowBook(Sandeep, businessInsightsBook);
library.BorrowBook(Akhil, analyticsAction);


Console.WriteLine("");
Console.WriteLine("Books After Borrowing:");
Console.WriteLine("Books In Library:");
foreach (var book in library.DisplayBooks)
{
    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Available Copies: {book.AvailableCopies}");
}



