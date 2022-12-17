namespace GradeBook
{
    class Book 
    {
      //constructor
      public Book(string name)
      {
        grades = new List<double>();
        this.name = name;
      }
      public void AddGrade(double grade)
      {
        grades.Add(grade);
      }
      
      public void showStaistics()
      {
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
      //state
      List<double> grades;
      private string name;
    }
}