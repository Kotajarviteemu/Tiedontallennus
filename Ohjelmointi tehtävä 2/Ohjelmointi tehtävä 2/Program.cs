using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ohjelmointi_tehtävä_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = @"D:\Visualstudiosettia\Nimi.txt";
            if(File.Exists(tiedosto))
            {

                string aiempiArvo = File.ReadAllText(tiedosto);
                    Console.WriteLine("Edellinen Nimi " + aiempiArvo);
            }






            string Nimi ="";
            Console.Write("Anna nimesi: ");
            string syöte = Console.ReadLine();
            Nimi = syöte;

            //tiedostoon kirjoitus

            //
          
            File.WriteAllText(tiedosto, Nimi.ToString());
            Console.WriteLine("Nimi Tallennettu");
            Console.ReadLine();

            //lukeminen tiedostosta

        }
    }
}
