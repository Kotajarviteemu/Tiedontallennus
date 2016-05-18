using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennusCon
{
    class Program
    {
        static void Main(string[] args)
        {   string tiedosto = @"D:\Visualstudiosettia\lämpötila.txt";
            //Luetaan tiedostosta aiemmin asetettu lämpötila 
            if (File.Exists(tiedosto))
            {
                string aiempiArvo = File.ReadAllText(tiedosto);
                Console.WriteLine("aiemmin asetettu lämpötila on " + aiempiArvo + " astetta.");

            }
            else
            {
                Console.WriteLine("Tervetuloa!");
            }


            int lämpötila = 0;
            Console.Write("Anna uusi lämpötila: ");
            string syöte = Console.ReadLine();
            lämpötila = int.Parse(syöte);

            //tiedostoon kirjoittaminen
           
            File.WriteAllText(tiedosto, lämpötila.ToString());
            Console.WriteLine("Uusi lämpötila tallennettu.");

            Console.ReadLine();
        }
    }
}
