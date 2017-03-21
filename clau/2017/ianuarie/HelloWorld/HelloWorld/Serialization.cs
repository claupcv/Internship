using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace HelloWorld
{
    [Serializable]
    public class Person
    {

        //Json serialization
        public string name;
        public int age;

        //Xml serialization
        private String firstname, lastname;

        public Person()
        {
            firstname = "Dic1";
            lastname = "Mark1";
        }

        public Person(String firstName, String lastName)
        {
            firstname = firstName;
            lastname = lastName;
        }

        public void ForTest()
        {
            //string test = "pcv";
        }
    }

    public static class  Serialization
    {
        public static void SerializationInstanceXml()
        {
            string filepathString = Program.pathToProject + "Serialization.xml";
            List<Person> ls = new List<Person>();
            ls.Add(new Person("Jon","Dick"));
            XmlSerializer b = new XmlSerializer(typeof(List<Person>));
            FileStream file = new FileStream(filepathString, FileMode.OpenOrCreate);

            //serialization
            b.Serialize(file, ls);
            
            file.Close();
        }

        public static void SerializationInstanceJson()
        {
            string filepathString = Program.pathToProject + "Serialization.xml";
            Person ls = new Person();
            ls.name = "Dick";
            ls.age = 40;

            DataContractJsonSerializer b = new DataContractJsonSerializer(typeof(Person));
            FileStream file = new FileStream(filepathString, FileMode.OpenOrCreate);

            //serialization
            b.WriteObject(file, ls);

            file.Close();
        }
    }
}
