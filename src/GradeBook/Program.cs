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

         book.AddGrade(13.1);
         var numbers = new[] {12.7, 10.3, 6.11, 4.1 };
         var grades = new List<double>() {12.7, 10.3, 6.11, 4.1 };
         grades.Add(56.1);

         var result = 0.0;
         var highGrade = double.MinValue;
         var lowGrade = double.MaxValue;
         foreach(var number in grades)
         {
          lowGrade = Math.Min(number, lowGrade);
          highGrade = Math.Max(number, highGrade);
          result += number;
         }
         result/=grades.Count;
         Console.WriteLine($"The lowest grade is {lowGrade}");
         Console.WriteLine($"The highest grade is {highGrade}");
         Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}