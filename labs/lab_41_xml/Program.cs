using System;
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
                    new XElement("level 11", 100),
                    new XElement("level 12", 100)
                )
            );



            Console.WriteLine(xml02);
        }
    }
}
