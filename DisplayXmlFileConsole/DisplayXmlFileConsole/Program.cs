using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DisplayXmlFileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument Kirjakauppa = new XmlDocument();
            string tiedosto = @"D:\Visualstudiosettia\bookstore.xml";
            Kirjakauppa.Load(tiedosto);
            Kirjakauppa.Save(Console.Out);
            Console.ReadKey();
        }
    }
}
