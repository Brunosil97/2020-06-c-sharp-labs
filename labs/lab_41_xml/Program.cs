using System;
using System.Xml;
using System.Xml.Linq;

namespace lab_41_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create some XML
            var xml01 = new XElement("TEST", 1);
            Console.WriteLine(xml01);

            //sub element
            var xml02 = new XElement("root",
                new XElement("levels",
                    new XAttribute("width", 22),
                    new XElement("level1", 100),
                    new XElement("level2", 400)
                ),
                new XElement("level1",
                    new XElement("level1.1", 100),
                    new XElement("level1.2", 100)
                )
            );
            Console.WriteLine(xml02);

            //write data to disk
            var doc02 = new XDocument(xml02);
            doc02.Save("XMLdoc02.xml");
            //read

            var readDoc02 = new XmlDocument();
            readDoc02.Load("XMLdoc02.xml");

            //print
            Console.WriteLine(readDoc02.InnerXml);
        }
    }
}
