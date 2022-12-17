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
      
      //state
      List<double> grades;
      private string name;
    }
}