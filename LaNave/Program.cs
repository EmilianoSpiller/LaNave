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
            Nave primaNave= new Nave();
            primaNave.Nome = "Splendida";
            primaNave.Stazza= 1000;
            primaNave.Velocità = 10;
            Console.WriteLine("Dati della prima nave: {0}", primaNave.ToString());
            primaNave.Vara();
            Console.WriteLine("Dati della prima nave dopo il varo: {0}\n", primaNave.ToString());
           
            Nave secondaNave = new Nave("Magnifica",2000,20,true);
            Console.WriteLine("Dati della seconda nave: {0}", secondaNave.ToString());
            Console.WriteLine("La nave {0} è varata? : {1}\n", secondaNave.Nome,secondaNave.IsVarata());

            Nave n1 = new Nave("Magica", 400, 40);
            Nave n2 = new Nave("Magica", 400, 40);
            string msg = (n1 == n2) ? "**uguali**": "**diverse**";
            Console.WriteLine(msg.ToUpper()+'\n');
            
            Console.WriteLine(n1.Equals(n2));
            Console.WriteLine(n1.GetHashCode());
            Console.WriteLine(n2.GetHashCode());

            Nave terzaNave;
            if(Nave.TryParse("Fantastica,800,pp,false", out terzaNave))
            {
                Console.WriteLine("Dati della terza nave: {0}", terzaNave.ToString());
            }
            else
            {
                Console.WriteLine("Dati terzaNave errati");
            }
            Console.WriteLine("\n\n*******************");
            Nave quartaNave;
            try
            {
                quartaNave = Nave.Parse("Eroica,8000,gatt,true");
                Console.WriteLine(quartaNave.Stazza);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dati della quarta nave non corretti: {0}", ex.Message); 
            }
            Console.WriteLine("quinta nave con posizione e rotta");
            Nave n5 = new Nave("Quinta Nave", 660, 33, true);
            n5.Stato = StatoNave.Navigazione;
            Posizione p1 = new Posizione(10, 20);
            Posizione p2 = new Posizione(20, 30);
            Posizione p3 = new Posizione(30, 40);
            Comandante com;
            Comandante.TryParse("Cristoforo,Colombo", out com);
            com.ToString();
            n5.Capitano = com;
            Console.WriteLine(n5.ToString());
            Console.WriteLine(n5.Capitano.ToString());
            List<Posizione> rottaNave = new List<Posizione>();
            rottaNave.Add(p1);
            rottaNave.Add(p2);
            rottaNave.Add(p3);
            n5.Rotta = rottaNave;
            List<Posizione> rottaNaveEstratta = n5.Rotta;
            foreach(Posizione pos in rottaNaveEstratta)
            {
                Console.Write("{0}\n",pos.ToString());
            }
           
        }
    }
}
