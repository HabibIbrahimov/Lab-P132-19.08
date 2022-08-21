using System;
using System.Drawing;

namespace _19._08._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product class yaradin:
            // -No
            // - Name
            // - Price
            // - Count

            //Book class - Productdan miras alır 
            // - Genre

            //No, Name ve Price dəyərləri təyin olunmadan Product obyekti yaradıla bilməz

            Book book = new Book(25, "Kitab", 299)
            {
                Count = 10,
                Genre = "Fantasy",
            };

            Console.WriteLine($"{book.No} \n{book.Name}\n {book.Price}\n {book.Count}\n {book.Genre}");


        }
    }
}
