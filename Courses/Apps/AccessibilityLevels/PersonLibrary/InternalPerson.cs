using System;

namespace PersonLibrary
{
  internal class InternalPerson
  {
    private void SayHelloPrivate()
    {
      Console.WriteLine("InternalPerson - Hello, from a private method!");
    }

    protected void SayHelloProtected()
    {
      Console.WriteLine("InternalPerson - Hello, from a protected method!");
    }

    internal void SayHelloInternal()
    {
      Console.WriteLine("InternalPerson - Hello, from an internal method!");
    }

    protected internal void SayHelloProtectedInternal()
    {
      Console.WriteLine("InternalPerson - Hello, from a protected internal method!");
    }

    public void SayHelloPublic()
    {
      Console.WriteLine("InternalPerson - Hello, from a public method!");
    }
  }
}
