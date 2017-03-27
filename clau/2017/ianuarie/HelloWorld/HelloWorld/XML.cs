using System;
using System.Xml;
using System.IO;

namespace HelloWorld
{
    

    public class Xml
    {
        public static void LoadXmlFromDOcument()
        {
            //get XML from file
            string filepathString = Program.pathToProject + "booksData.xml";
            
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepathString);
            // Create an XmlNamespaceManager to resolve the default namespace.
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
            nsmgr.AddNamespace("bk", "urn:newbooks-schema");
            XmlNode book;
            XmlElement root = xmlDoc.DocumentElement;
            book = root.SelectSingleNode("bk:book", nsmgr);
            XmlNodeList itemNodes = root.SelectNodes("bk:book",nsmgr);

            foreach (XmlNode bookElements in itemNodes)
            {
                    Console.WriteLine(bookElements.Name );
            }
            
        }

        public static void MethodXmlWriter()
        {
            XmlWriter xmlWriter = XmlWriter.Create(Program.pathToProject + "xmlWriter.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("users");

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "4211");
            xmlWriter.WriteString("John Doe");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "39111");
            xmlWriter.WriteString("Jane Doe");
            //xmlWriter.WriteEndDocument();

            xmlWriter.Close();
        }

        public static void MethodXmlDocument()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("users");
            xmlDoc.AppendChild(rootNode);

            XmlNode userNode = xmlDoc.CreateElement("user");
            XmlAttribute attribute = xmlDoc.CreateAttribute("age");
            attribute.Value = "42";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = "John Doe";
            rootNode.AppendChild(userNode);

            userNode = xmlDoc.CreateElement("user");
            attribute = xmlDoc.CreateAttribute("age");
            attribute.Value = "39";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = "Jane Doe";
            rootNode.AppendChild(userNode);

            userNode = xmlDoc.CreateElement("doc");
            attribute = xmlDoc.CreateAttribute("type");
            attribute.Value = "excel";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = "Factura";
            rootNode.AppendChild(userNode);

            xmlDoc.Save(Program.pathToProject + "xmlDocument.xml");
        }
    }
}
