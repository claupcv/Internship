using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate string SayHelloDelegate(string name);

    public delegate void AddNumDelegate(int a , int b);

	public delegate double AreaAndPerimeterDelegate(int width, int heigth);

	public class DelegateExample
    {
        public void AddNum(int a , int b)
        {			
            Console.WriteLine($"add : {a+b}");
        }
		public void DiffNum(int a, int b)
		{
			Console.WriteLine($"diff : {a - b}");
		}
		public  static string SayHello(string name)
        {
            return "Hello " + name;
        }

		public double GetPerimeter(int width, int heigth )
		{
			Console.WriteLine($"Get perimeter : {width + heigth}");
			return width + heigth;
		}

		public double GetArea(int width, int heigth)
		{
			Console.WriteLine($"Get Area : {width * heigth}");
			return width * heigth;
		}
	}
}
