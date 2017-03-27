using System;
using System.IO;
using System.Text;
using System.Globalization;

namespace HelloWorld
{
    class MemoryStreamZ
    {
        public static void MemStream()
        {
            
            int count;
            byte[] byteArray;
            UnicodeEncoding uniEncoding = new UnicodeEncoding();

            // Create the data to write to the stream.


            //get from string
            //byte[] firstString = uniEncoding.GetBytes("Invalid file path characters are: ");
            //get from file
            byte[] firstString = File.ReadAllBytes("file.bin");
            string tetxFileDecoded = Encoding.UTF8.GetString(firstString);
            Console.WriteLine(tetxFileDecoded);

            byte[] secondString = uniEncoding.GetBytes(Path.GetInvalidPathChars());

            using (MemoryStream memStream = new MemoryStream(100))
            {
                // Write the first string to the stream.
                memStream.Write(firstString, 0, firstString.Length);

                memStream.Seek(0, SeekOrigin.Begin);
                // Write the stream properties to the console.
                CultureInfo curentCulture = CultureInfo.GetCultureInfo("ar-QA");
                Console.WriteLine(
                    "Capacity = {0}, Length = {1}, Position = {2}\n",
                    memStream.Capacity.ToString(curentCulture),
                    memStream.Length.ToString(curentCulture),
                    memStream.Position.ToString(curentCulture));

                // Set the position to the beginning of the stream.
                memStream.Seek(0, SeekOrigin.Begin);

                // Read the first 20 bytes from the stream.
                byteArray = new byte[memStream.Length];
                //count = memStream.Read(byteArray, 0, 20);
                count = 0;

                // Read the remaining bytes, byte by byte.
                while (count < memStream.Length)
                {
                    byteArray[count] = Convert.ToByte(memStream.ReadByte());
                    Console.WriteLine(count + "---" + Encoding.UTF8.GetString(byteArray));
                    count++;
                }

                

                using (FileStream file = new FileStream("file.bin", FileMode.Open, System.IO.FileAccess.Read))
                {
                    // Set the position to the beginning of the stream.
                    memStream.Position = 0;
                    byte[] bytes = new byte[memStream.Length];
                    memStream.Read(bytes, 0, (int)memStream.Length);
                    Console.WriteLine(memStream.Read(bytes, 0, (int)memStream.Length));
                    //file.Write(bytes, 0, bytes.Length);
                    memStream.Close();
                }
            }
        }
    }
}
