using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace CSharpDotNetLearning
{
    static class StringExcercises
    {
        //the array of delimiters with the char elements after witch it comes the character with uppercase(or another char rom the list)
        public static string[] delimitersArray =  { " ", ".", ",", "!", "?" };

        //string to be processed
        static String text;

        //list of index positions where the char will have to be Uppercase
        static List<int> charFoundList = new List<int>();

        //crteate the string builder 
        static StringBuilder textStringBuilder = new StringBuilder();

        //current elememnt from the "text"
        static string currentElem;

        static StringExcercises()
        {
            text = string.Empty;
            currentElem = string.Empty;
        }

        //browse the "text" char by char 
        static void BrowseString()
        {            
            //loop the whole string "text" char (last char of the "text" will not be checked because after it there is no other char).
            for (int i = 0; i < text.Length; i++)
            {
                // set the curent Char(element) 
                currentElem = SetElement(i);

                // first elem does not need to be checked
                if (i > 0) 
                {
                    // set the pevious Char(element) 
                    string prevElem = SetElement(i-1); // prevElem will not give error because the if condition of string loop does not check the first elemenet of the string

                    //Based on flag set element to UPPER
                    CheckIfElementToBeUpper(prevElem);                    
                }
                // add the char to string builder(also with the Uppercase caracter) to form the new string with the Uppercase
                SetToStringBuilder();
            }
        }
        static void CheckIfElementToBeUpper(string prevElem)
        {
            bool upperCaseChar = false;
            //check if the curent char is from the list of delimiters
            if (Array.IndexOf(delimitersArray, prevElem) >= 0)
            {
                //check if the next char is part of the list of delimiters
                if (Array.IndexOf(delimitersArray, currentElem) == -1)
                {
                    //change into stringbuilder to Upperchase chars
                    upperCaseChar = true;
                }
            }
            //check if an char is set for converting to Uppercase
            CheckIfCharIsSetForUpper(upperCaseChar);
        }
        static string SetElement(int position)
        {
            string element = StringExcercises.text[position].ToString();
            return element;
        }

        static void CheckIfCharIsSetForUpper(bool upperCaseChar)
        {
            if (upperCaseChar == true)
            {
                // update the lowercase char to uppercase char
                SetCharToUppercase();
            }
        }
        //set to Upper the string 
        static void SetCharToUppercase()
        {
            currentElem = currentElem.ToUpper();            
        }

        //set append into string builder the character
        static void SetToStringBuilder()
        {
            textStringBuilder.Append(currentElem);
        }

        //get the string from file
        static void GetStringFromFile(){
            
            try
            {
                //the string to be processed
                using (StreamReader sr = new StreamReader(Program.pathToProject + "temp.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    text = sr.ReadToEnd();
                }
            }
            catch
            {
                //if problem with file or string in file put "text" to null
                text = null;
            }
            
        }
        // check if string from file is empty or Null
        static bool CheckIfEmptyString()
        {
            if (string.IsNullOrEmpty(text))
                return false;
            else
                return true;
        }
        public static void RunParseString(){
            String textStr = string.Empty;


            //start Watch for measuring the time for procesing
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // get the string to parse from file
            GetStringFromFile();
            Console.WriteLine(textStr);
            if (CheckIfEmptyString() == true) {
                BrowseString();
            }
            else
            {
                Console.WriteLine("The string is empty or null!!!");
            }                

            // browse the string from the file            
            Console.WriteLine(textStringBuilder);

            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            Console.WriteLine("=================================================================");
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }

    
}