namespace AnotherLibrary
{
  public class AnotherClass
  {
    public void DoSomething()
    {
      // Acest apel da eroare
      // Error CS0122  'InternalPerson' is inaccessible due to its protection level
      var person = new PersonLibrary.InternalPerson();
    }
  }
}
