using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    using System.Runtime.InteropServices;

    class Indexers
    {
        int iNumb;
        string iName, iSurname;
        private double iPrice;

        public Indexers(int iNumb, string iName, string iSurname, double iPrice)
        {
            this.iNumb = iNumb;
            this.iName = iName;
            this.iSurname = iSurname;
            this.iPrice = iPrice;
        }

        public object this[int indexes]
        {
            get
            {
                if (indexes == 0)
                {
                    return this.iNumb;
                }
                else if (indexes == 1)
                {
                    return this.iName;
                }
                else if (indexes == 2)
                {
                    return this.iSurname;
                }
                else if (indexes == 3)
                {
                    return this.iPrice;
                }
                return null;
            }
            set
            {
                if (indexes == 0)
                {
                    this.iNumb = (int)value;
                }
                else if (indexes == 1)
                {
                    this.iName = (string)value;
                }
                else if (indexes == 2)
                {
                    this.iSurname = (string)value;
                }
                else if (indexes == 3)
                {
                    this.iPrice = (double)value;
                }
            }
        }

    }

    public static class  TestIndexers
    {
        public static void TestIndexersMethod()
        {
            Indexers index = new Indexers(1001, "Clau", "Pcv", 30.50);
            Console.WriteLine("Number:" + index[0]);
            Console.WriteLine("Name:" + index[1]);
            Console.WriteLine("Surname:" + index[2]);
            Console.WriteLine("Price:" + index[3]);
            index[1] = "Temp";

            Console.WriteLine("===========================");

            Console.WriteLine("Number:" + index[0]);
            Console.WriteLine("Name:" + index[1]);
            Console.WriteLine("Surname:" + index[2]);
            Console.WriteLine("Price:" + index[3]);

        }
    }

}
