using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaNave
{
    internal class Comandante  //when one-to-one association is required
    {
        string _nome;
        string _cognome;
        Nave _imbarcazione;
        public Comandante(string nome, string cognome)
        {
            _nome = nome;
            _cognome = cognome;
        }
        public string Nome { get;set; }
        public string Cognome { get;set; }
        public Nave Imbarcazione { get;set;}
        public override string ToString()
        {
            return String.Format("nome: {0} - cognome: {1}",_nome,_cognome); 
        }
        public static bool TryParse(string strComandante, out Comandante nuovoComandante)
        {
            bool creato = false;
            nuovoComandante= null;
            try
            {
                string[] str = strComandante.Split(',');
                nuovoComandante = new Comandante(str[0], str[1]);
                creato=true;
            }
            catch
            {
                Console.WriteLine("formato nave non corretto");
            }
            return creato;

        }
        public static Comandante Parse(string strComandante)
        {
            Comandante nuovoComandante = null;
            if(!Comandante.TryParse(strComandante, out nuovoComandante))
            {
                throw new Exception("errore Com");
            }
            return nuovoComandante;
        }
    }

}
