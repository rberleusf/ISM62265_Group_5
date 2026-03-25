namespace Competition2.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int AvailableCopies { get; set; }
        public int Id { get; set; }

        public void BorrowBook()
        {
            // if (AvailableCopies > 0)
            // {
            //     AvailableCopies--;
            //     Console.WriteLine($"You have borrowed '{Title}' by {Author}.");
            // }
            // else
            // {
            //     Console.WriteLine($"Sorry, '{Title}' is currently unavailable.");
            // }
        }
    }
    
}

//

//Book → Includes properties for Title, Author, ISBN, AvailableCopies, and method BorrowBook
