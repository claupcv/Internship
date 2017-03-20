using System;
using System.Text;

namespace CSharpDotNetLearning
{
    // Declare pand scroll trought an array unidimensional / mulidimesional

    class DeclarareShowSortSumArrayUniMultiDimensional
    {
        //
        public static void DeclareScrollUnidimArray()
        {
            // creating the unidimensional array
            int[] unidimArray = new int[]{4,2,5,1,3};

            
            Console.WriteLine("Unidmiensional Array {4,2,5,1,3}");

            //find element into an array
            global::System.Console.Write("Input nomber to search:");
            int numToSearch = Convert.ToInt32(Console.ReadLine());
            int indexFound = Array.IndexOf(unidimArray, numToSearch);
            // + 1 because aray start from 0
            indexFound++;

            string indexFoundString = indexFound <= 0 ? "None" : indexFound.ToString();
            Console.WriteLine("Search for no [{0}] index position {1}:", numToSearch, indexFoundString);

            //sort the elements
            Array.Sort(unidimArray);

            //Declaring the elements where the string of the arrays will be put.
            string stringArrayElements = string.Empty;

            //looping the array with a foreach and puting in into a string
            foreach(int element in unidimArray){
                //add at the end of string the curent element + the ","
                stringArrayElements = stringArrayElements + element + " ";
            }

            //remove the last " "
            stringArrayElements = stringArrayElements.Trim();
            Console.WriteLine("Sorted : {0}", stringArrayElements);

            // Reverses the sort of the values of the Array.
            Array.Reverse(unidimArray);
            //golire string
            stringArrayElements = string.Empty;
            //looping the inversed array with a foreach and puting in into a string
            foreach (int element in unidimArray)
            {
                //add at the end of string the curent element + the ","
                stringArrayElements = stringArrayElements + element + " ";
            }

            //remove the last " "
            stringArrayElements = stringArrayElements.Trim();
            Console.WriteLine("Reversed array : {0}", stringArrayElements);

            Console.WriteLine("===============================");
            
        }

        public static void DeclareScrollMultidimArray<T>(T[,] multidimArray)
        {
                      

            Console.WriteLine("Multidimensional Array");

            //Declaring the elements where the string of the arrays will be put.
            StringBuilder sbArrayElements = new StringBuilder();

            //looping the array with a foreach and puting in into a string
            for (int i = 0; i < multidimArray.GetLength(0); i++ )
            {
                for (int j = 0; j < multidimArray.GetLength(1); j++)
                {
                    //add at the end of string the curent element + the ","
                    sbArrayElements.Append(multidimArray[i, j]).Append(" ");
                }
                sbArrayElements.Append("  ");
            }

            //remove the last " "
            string stringArrayElements = sbArrayElements.ToString().Trim();

            Console.WriteLine(stringArrayElements);
        }


        static int[,] DeclareMultiArray(int i)
        {
            int[,] multiArray = new int[3,2] { {1+i, 2+i}, {3+i, 4+i}, {5+i, 6+i} };
            return multiArray;
        }
        // Sum of two arrays
        public static void SumOf2Arrays()
        {
            //random numbers for random 2D arrays
            Random rand = new Random();

            //create the 2 multidim arrays
            int[,] multiArrayOne = DeclareMultiArray(rand.Next(0,100));
            int[,] multiArrayTwo = DeclareMultiArray(rand.Next(0,100));
            
            //show the 2 DeclarareScrollArrayUniMultiDimensional arrays
            DeclareScrollMultidimArray<int>(multiArrayOne);
            DeclareScrollMultidimArray<int>(multiArrayTwo);

            Console.WriteLine("Sum 2 Multidimensional Array");

            //Declaring the elements where the string of the arrays will be put.
            StringBuilder sbArrayElements = new StringBuilder();

            //Sum the multidim arrays, or can be don with 
            //looping the array with a foreach and puting in into a string
            int Sum = 0;
            for (int i = 0; i < multiArrayOne.GetLength(0); i++)
            {
                for (int j = 0; j < multiArrayOne.GetLength(1); j++)
                {
                    //make the Sum of the elemnts multiArrayOne teh same positions of the array's elements
                    Sum = (int)(multiArrayOne[i, j] + multiArrayTwo[i, j]);
                    sbArrayElements.Append(Sum).Append(" ");
                }
                sbArrayElements.Append("  ");
            }
            //remove the last " "
            string stringArrayElements = sbArrayElements.ToString().Trim();

            Console.WriteLine(stringArrayElements);
        }
    }
}
