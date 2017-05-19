using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccess
{
	public class XMLContext : XmlDocument
	{
		public XMLContext()
		{
			XmlDocument doc = new XmlDocument();
			XmlWriter writer = XmlWriter.Create("XMLPerson.xml");

			//doc.LoadXml();
		}

		public DbSet<Person> Persons { get; set; }


	}
}
