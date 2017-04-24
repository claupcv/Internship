// when can be used nested class : SomeEntity.Collection instead of EntityCollection< SomeEntity>.
// It is a way of logically grouping classes that are only used in one place.
// It increases encapsulation.
// Nested classes can lead to more readable and maintainable code.

using System;

namespace Classes
{
    class NestedType
    {
        public class ListElement
        {
            public int Value { get; private set; }
 
            public int Index { get; private set; }
 
            public ListElement(int value, int index)
            {
              this.Value = value;
              this.Index = index;
            }
        }
 
        public ListElement[] Elements { get; private set; }

        public NestedType(int[] array)
        {
            Console.Write("ListElements : ");
            if(array == null)
            {
                array = new int[0];
            }
 
            this.Elements = new ListElement[array.Length];
            for(int i= 0; i < array.Length; i++)
            {
                // here is called the nested class ListElement.
                this.Elements[i] = new ListElement(array[i], i);
                Console.Write("[{0}]={1} ",this.Elements[i].Index, this.Elements[i].Value);
            }
        }

    }
}
