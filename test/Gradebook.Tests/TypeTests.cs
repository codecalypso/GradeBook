namespace GradeBook.Tests
{
  public class TypeTests
  {
    [Fact]
     public void StringBehavesLikeValueTypes()
    {
      string name = "Stacy";
      var upper = MakeUppercase(name);

      Assert.Equal("STACY", upper);
      Assert.Equal("Stacy", name);
    }

    private string MakeUppercase(string parameter)
    {
      return parameter.ToUpper();
    }

    [Fact]
    public void ValueTypesAlsoPassByValue()
    {
      var x = GetInt();
      SetInt(x);

      Assert.Equal(3, x);
    }
    private void SetInt(int z)
    {
      z = 42;
    }

    private int GetInt()
    {
      return 3;
    }

    [Fact]
    public void CSharpCanPassByRef()
    {
      var book1 = GetBook("Book 1");
      GetBookSetName(ref book1, "New Name");
      
      Assert.Equal("New Name", book1.Name);
    }

    private void GetBookSetName(ref Book book, string name)
    {
      book = new Book(name);
    }

    [Fact]
    public void CSharpIsPassByValue()
    {
      var book1 = GetBook("Book 1");
      GetBookSetName(book1, "New Name");
      
      Assert.Equal("Book 1", book1.Name);
    }

    private void GetBookSetName(Book book, string name)
    {
      book = new Book(name);
    }

    [Fact]
    public void CanSetNameFromReference()
    {
      var book1 = GetBook("Book 1");
      SetName(book1, "New Name");
      
      Assert.Equal("New Name", book1.Name);
    }

    private void SetName(Book book, string name)
    {
      book.Name = name;
    }

    [Fact]
    public void GetBookReturnsDifferentObjects()
    {
      var book1 = GetBook("Book 1");
      var book2 = GetBook("Book 2");

      Assert.Equal("Book 1", book1.Name);
      Assert.Equal("Book 2", book2.Name);
      Assert.NotSame(book1, book2);
    }

    [Fact]
    public void TwoVarsCanReferenceSameObject()
    {
      var book1 = GetBook("Book 1");
      var book2 = book1;
     //both of these references point to the same obj in memory
      Assert.Same(book1, book2);
      Assert.True(Object.ReferenceEquals(book1, book2));
    }
    Book GetBook(string name)
    {
      return new Book(name);
    }
  }
}

