using System;

namespace PersonLibrary
{
  public class PublicPerson
  {
    private void SayHelloPrivate()
    {
      Console.WriteLine("PublicPerson - Hello, from a private method!");
    }

    protected void SayHelloProtected()
    {
      Console.WriteLine("PublicPerson - Hello, from a protected method!");
    }

    internal void SayHelloInternal()
    {
      Console.WriteLine("PublicPerson - Hello, from an internal method!");
    }

    protected internal void SayHelloProtectedInternal()
    {
      Console.WriteLine("PublicPerson - Hello, from a protected internal method!");
    }

    public void SayHelloPublic()
    {
      Console.WriteLine("PublicPerson - Hello, from a public method!");
    }
  }
}
