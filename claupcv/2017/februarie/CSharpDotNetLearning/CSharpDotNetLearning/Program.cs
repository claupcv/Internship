﻿using System;



namespace CSharpDotNetLearning
{
    class Program
    {
        public static readonly string pathToProject = AppDomain.CurrentDomain.BaseDirectory + @"docs\";
        static void Main(string[] args)
        {
            // Excercises
            /// Arrays :
            
            //// Declare pand scroll trought an array unidimensional / mulidimesional
            //DeclarareShowSortSumArrayUniMultiDimensional.DeclareScrollUnidimArray();
            //DeclarareScrollArrayUniMultiDimensional.DeclareScrollMultidimArray<int>(new int[2,3] { {1, 2, 3}, {4, 5, 6} });
            //DeclarareShowSortSumArrayUniMultiDimensional.SumOf2Arrays();
            FirstLetterOfWordUpper stringParsed = new FirstLetterOfWordUpper();
            stringParsed.RunParseString();


            Console.ReadKey();
        }
    }
}
