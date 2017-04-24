namespace PersonLibrary
{
  public static class Demo
  {
    public static void DemoInternalPerson()
    {
      // putem utiliza clasa InternalPerson aici
      // pentru ca suntem in acelasi assembly (PersonLibrary)
      InternalPerson p = new InternalPerson();

      // Acest apel da eroare
      // Error CS0122  'InternalPerson.SayHelloPrivate()' is inaccessible due to its protection level
      p.SayHelloPrivate();

      // Acest apel da eroare
      // Error CS0122  'InternalPerson.SayHelloProtected()' is inaccessible due to its protection level
      p.SayHelloProtected();

      // Functioneaza pentru ca suntem in acelasi assembly
      p.SayHelloInternal();

      // Functioneaza pentru ca suntem in acelasi assembly
      p.SayHelloProtectedInternal();

      // Functioneaza pentru ca e metoda publica
      p.SayHelloPublic();
    }

    public static void DemoPublicPerson()
    {
      // putem utiliza clasa PublicPerson aici
      // pentru ca este o clasa publica
      PublicPerson p = new PublicPerson();

      // Acest apel da eroare
      // Error CS0122  'PublicPerson.SayHelloPrivate()' is inaccessible due to its protection level
      p.SayHelloPrivate();

      // Acest apel da eroare
      // Error CS0122  'PublicPerson.SayHelloProtected()' is inaccessible due to its protection level
      p.SayHelloProtected();

      // Functioneaza pentru ca suntem in acelasi assembly
      p.SayHelloInternal();

      // Functioneaza pentru ca suntem in acelasi assembly
      p.SayHelloProtectedInternal();

      // Functioneaza pentru ca e metoda publica
      p.SayHelloPublic();
    }
  }
}
