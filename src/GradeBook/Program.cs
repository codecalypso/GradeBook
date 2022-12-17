// See https://aka.ms/new-console-template for more information
using System;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
         var book = new Book("Stacy's Grade Book");
         book.AddGrade(89.1);
         book.AddGrade(60.0);
         book.AddGrade(100.0);
         book.showStaistics();
        }
    }
}