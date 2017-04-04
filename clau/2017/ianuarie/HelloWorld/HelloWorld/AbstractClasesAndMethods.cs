using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public abstract class AbstractClasesAndMethods
    {
        public static int testStaticField = 1;
        public int abstsactField = 1;
        public void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }

        public abstract void Sum(int x, int y);
    }

    public class ChildAbstractClasesAndMethods : AbstractClasesAndMethods
    {
        public override void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public static void ChildAbstractMethod()
        {
            // cannot create instance of abstract clases
            // AbstractClasesAndMethods abstractInstance = new AbstractClasesAndMethods();

            AbstractClasesAndMethods absIstance = new ChildAbstractClasesAndMethods();
            absIstance.Multiply(2, 5);
            absIstance.Sum(3, 6);
        } 
    }
}
