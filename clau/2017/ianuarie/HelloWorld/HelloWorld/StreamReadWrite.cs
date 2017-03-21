using System;
using System.IO;
namespace HelloWorld
{
    

    public class StreamReadWrite
    {
        public static string WriteToFile(string fileName)
        {
            StreamWriter writer = null;
            try
            {
                string stringFromFile = StreamReadWrite.ReadFromFile(fileName);

                writer = new StreamWriter(fileName);
                writer.WriteLine(stringFromFile + "Write test :" + DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
                
            }

            return "Succesful Write!!" + DateTime.Now;
        }

        public static string ReadFromFile(string filename)
        {
            StreamReader reader = null;
            var text = string.Empty;
            try
            {
                reader = new StreamReader(filename);
                text = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                
            }
            //Console.WriteLine("Finally runing here!!!");
            
            return text;
        }

        public static void ProgramStreamReadWrite()
        {

            string fileName = Program.pathToProject + "stream.txt";
            Console.WriteLine(StreamReadWrite.ReadFromFile(fileName));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(StreamReadWrite.WriteToFile(fileName));
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(StreamReadWrite.ReadFromFile(fileName));
        }
    }
}