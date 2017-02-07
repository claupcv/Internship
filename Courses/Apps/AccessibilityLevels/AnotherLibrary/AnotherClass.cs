namespace AnotherLibrary
{
  public class AnotherClass
  {
    public void DoSomethingWithInternalPerson()
    {
      // Acest apel da eroare
      // Error CS0122  'InternalPerson' is inaccessible due to its protection level
      var person = new PersonLibrary.InternalPerson();
    }

    public void DoSomethingWithPublicPerson()
    {
      var person = new PersonLibrary.PublicPerson();

      // Acest apel da eroare
      // Error CS0122  'PublicPerson.SayHelloPrivate()' is inaccessible due to its protection level
      person.SayHelloPrivate();

      // Acest apel da eroare
      // Error CS0122  'PublicPerson.SayHelloProtected()' is inaccessible due to its protection level
      person.SayHelloProtected();

      // Acest apel da eroare
      // Error CS0122  'PublicPerson.SayHelloProtected()' is inaccessible due to its protection level
      person.SayHelloInternal();

      // Acest apel da eroare
      // Error CS0122  'PublicPerson.SayHelloProtected()' is inaccessible due to its protection level
      person.SayHelloProtectedInternal();

      // Functioneaza pentru ca e metoda publica
      person.SayHelloPublic();
    }
  }
}
