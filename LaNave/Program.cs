using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaNave
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Nave n1 = new Nave("Magica", 400, 40,5000,500,"kerosene", 6000, 600, "kerosene+");   
            Console.WriteLine(n1.Motore1.Potenza);
            Console.WriteLine(n1.Motore1.Carburante);
            Console.WriteLine(n1.Motore1.Cilindrata);      
            Console.WriteLine(n1.Motore2.Potenza);
            Console.WriteLine(n1.Motore2.Carburante);
            Console.WriteLine(n1.Motore2.Cilindrata);


        }
    }
}
