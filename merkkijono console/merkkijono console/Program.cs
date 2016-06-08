using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merkkijono_console
{
    class Program
    {
        static void Main(string[] args)
        
            
            {//poikkeus alkuun
            throw new.ApplicationExecption("pöö");

            //Huono Tapa
            string s = "ABC";
            for (int i = 0; i < 10000; i++)
            {
                s = s + "!";
            }
            //parempi tapa 
            StringBuilder builder = new StringBuilder("ABC");
            for (int i = 0; i < 10000; i++)
            {
                builder.Append("!");
            }
            s = builder.ToString();
        }
    }
}
