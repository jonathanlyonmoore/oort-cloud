using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader xmlReader = new XmlTextReader("cds.xml");
            xmlReader.Read();

            while (xmlReader.Read())
            {
                Console.Write(xmlReader.Value);
            }
            Console.Read();

            
        }
    }
}
