using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {

        public delegate int Sum3Numbers(int a1, int a2, int a3);

        public int CalculateSum3Numbers(int a1, int a2, int a3)
        {
            return a1 + a2 + a3;
        }

		public static void DelegatesExamples()
		{
			//instanciate the class
			DelegateExample classInstance = new DelegateExample();
			//classInstance.AddNum(10, 5);

			//add methods to new instance of delegates
			AddNumDelegate adD = classInstance.AddNum;
			adD += classInstance.DiffNum;
			SayHelloDelegate say = new SayHelloDelegate(DelegateExample.SayHello);

			adD.Invoke(5, 6);
			string str = say("PCV");


			str = DelegateExample.SayHello("PCV");
			Console.WriteLine(str);
		}

        public static void Main(string[] args)
        {
			
			Person person = new Person();
            person.Run();
			
			Console.WriteLine("================================");
			Program.DelegatesExamples();
			Console.WriteLine("================================");

            // ...
            // si apoi undeva in codul aplicatiei
            // ...

            // define some observers
            var observer1 = new IntegerCollectionChangeObserver("observer 1");
            var observer2 = new IntegerCollectionChangeObserver("observer 2");

            // define the observable collection
            ObservableIntegerCollection col = new ObservableIntegerCollection();

            // attach both observers
            col.OnCollectionEvent += observer1.OnReceiveCollectionEvent;
            col.OnCollectionEvent += observer2.OnReceiveCollectionEvent;

            // make a change upon the collection and observe results
            col.Add(1);
            // Outputs:
            // observer 1 > ElementAdded just happend, affected element is: 1
            // observer 2 > ElementAdded just happend, affected element is: 1

            // detach second observer
            col.OnCollectionEvent -= observer2.OnReceiveCollectionEvent; ;

            // make another change upon the collection and observe results
            col.Update(0, 2);
            // Outputs:
            // observer 1 > ElementUpdated just happend, affected element is: 2

            Console.ReadKey();

        }
    }
}
