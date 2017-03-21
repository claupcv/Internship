using System;
using System.Runtime.Serialization;

namespace HelloWorld
{
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
    public class SerializebleBook : ISerializable
    {
        private string name;

        private int id;

        public SerializebleBook(string nameVal, int idVal)
        {
            this.name = nameVal;
            this.id = idVal;
        }

        protected SerializebleBook(SerializationInfo info, StreamingContext context)
        {
            this.name = info.GetString("Name");
            this.id = info.GetInt32("Id");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

            info.AddValue("Name", this.name);
            info.AddValue("ID", this.id);
        }

        public string ToStringss()
        {
            return this.name + "." + this.id;
        }

        public static void RunSerializable()
        {
            string filepathString = Program.pathToProject + "ISerialization.xml";
            Stream fileStream = new FileStream(filepathString, FileMode.OpenOrCreate, FileAccess.Write);
            SerializebleBook book = new SerializebleBook("Clau", 10);

            BinaryFormatter binFormat = new BinaryFormatter();
            binFormat.Serialize(fileStream, book);
            Console.WriteLine("Ser Complete!");


        }

    }
}
