using System;
using System.Text;
namespace HelloWorld
{
    public static class EncodingAndDecoding
    {
        public static byte[] StringEncode(string text)
        {
            //Create encodings
            byte[] textEncode = Encoding.UTF8.GetBytes(text);
            return textEncode;
        }

        public static string StringDecode(byte[] byteString)
        {
            string textDecode = Encoding.UTF8.GetString(byteString);
            return textDecode;
        }

        public static void RunEncodingAndDecoding()
        {
            //get text to be converted
            string text = @"fC";
            Console.WriteLine("Original:" + text);

            //Encode the text
            byte[] byteEncoded = EncodingAndDecoding.StringEncode(text);
            string stringEncoded = Convert.ToBase64String(byteEncoded);
            Console.WriteLine("Encoded:" + stringEncoded);

            //decode the text
            string stringDecoded = EncodingAndDecoding.StringDecode(byteEncoded);
            Console.WriteLine("Decoded:" + stringDecoded);
        }
    }
}