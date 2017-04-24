using System;

namespace Classes
{
    public partial class PartialClassMethods
    {
        //methods cannot be otehr than private because at compile it have to be defined , 
        // if public can be defined in other assemblies
        partial void Partialmethod()
        {
            Console.WriteLine("Partial method");
        }
    }
}
