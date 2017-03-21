using System;
using System.Text;


namespace HelloWorld
{
    class InheritanceClass
    {
        public InheritanceClass(string text)
        {
            Console.WriteLine("InheritanceClass ctor in {0}...",text);
        }
    }
    public class BaseClass
    {
        InheritanceClass tempBase = new InheritanceClass("BaseClass"); 
        // this is called first because is the baseclass
        public BaseClass()
        {
            Console.WriteLine("BaseClass ctor");
        }

        //not good to use static method into a non-static class because this:  "DeriveinheritanceClass.Make();" will return a baseClass
        public static BaseClass Make()
        {
            return new BaseClass();
        }
       
    }
    public class DeriveinheritanceClass : BaseClass
    {
        InheritanceClass temp = new InheritanceClass("DeriveinheritanceClass"); 
        //this is called seccond because is baseclass
        public DeriveinheritanceClass()
        {            
            Console.WriteLine("DeriveinheritanceClass ctor ");
        }
    }
}
