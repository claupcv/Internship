using PersonLibrary;

namespace AnotherLibrary
{
  public class AnotherPublicPerson : PublicPerson
  {
    public void DoSomething()
    {
      var person = this;

      // Acest apel da eroare
      // Error CS0122  'PublicPerson.SayHelloPrivate()' is inaccessible due to its protection level
      person.SayHelloPrivate();

      // Acest apel functioneaza pentru ca suntem intr-o clasa derivata
      person.SayHelloProtected();

      // Acest apel da eroare
      // Error CS0122  'PublicPerson.SayHelloInternal()' is inaccessible due to its protection level
      person.SayHelloInternal();

      // Acest apel functioneaza pentru ca suntem intr-o clasa derivata
      person.SayHelloProtectedInternal();

      // Functioneaza pentru ca e metoda publica
      person.SayHelloPublic();
    }
  }
}
