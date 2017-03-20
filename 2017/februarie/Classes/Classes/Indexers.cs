using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Indexers
    {
        private readonly int[] array = { 1, 2, 3, 4, 5 };
        private string name="testIndexerByKey";
        // Acesta este un indexator
        // indexers use this , and is a special property
        public int this[int index]
        {
            get
            {

                return this.array[index];
            }
            set
            {
                this.array[index] = value;
            }
        }
        public string this[string key]
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(name)){
                    switch ( key.ToUpper())
                    {
                        case "NAME":
                        return this.name;
                    }
                    
                }
                return null;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(name))
                {
                    switch (key.ToUpper())
                    {
                        case "NAME":
                        this.name = value;
                        break;                    
                    }
                }
            }
        }

    }
}
