﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;

namespace XmlLukijaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("D:\\Visualstudiosettia\\bookstore.xml");
            Console.Write(doc.ToString());
            Console.ReadLine();
        
            
        }
    }
}
