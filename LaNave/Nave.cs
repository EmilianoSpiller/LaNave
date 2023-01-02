using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LaNave
{
    internal class Nave
    {
        string _nome;
        double _stazza;
        int _velocità;
        bool _varata;
        StatoNave _stato;
        Comandante _capitano;
        List<Posizione> _rotta;
        public Nave() { }
        public Nave(string nome, double stazza, int velocità, bool varata, Comandante capitano)
        {
            _nome = nome;
            _stazza = stazza;
            _velocità = velocità;
            _varata = varata;
            _capitano= capitano;
        }
        public Nave(string nome, double stazza, int velocità) : this(nome, stazza, velocità, false, null)
        { }

        public Nave(string nome, double stazza, int velocità, Comandante capitano) : this(nome, stazza, velocità, false, capitano)
        { _capitano = capitano; }
        public Nave(string nome, double stazza, int velocità, bool varata) : this(nome, stazza, velocità,varata,null)
        { }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public double Stazza
        {
            get;set;
        }
        public int Velocità
        {
            get;set;
        }
        public bool Varata
        {
            get;set;
        }
        public StatoNave Stato 
        {
            get;set;
        }
        public Comandante Capitano
        {
            get;set;
        }
        public override string ToString()   //To view the overload press ctrl+shift+space inside the parenthesis
        {
            return String.Format("{0},{1},{2},{3}", _nome,_stazza,_velocità,_varata);
        }

        public void Vara()
        {
            _varata=true;
        }
        public bool IsVarata()
        {
            return _varata;
        }
        public static bool operator ==(Nave n1,Nave n2)
        {
            return(n1.Nome== n2.Nome && n1.Stazza==n2.Stazza);
        }
        public static bool operator !=(Nave n1, Nave n2)
        {
            return !(n1==n2);
        }

        public override bool Equals(object obj)
        {
            return this == (Nave)obj;
        }
        public override int GetHashCode()
        {
            return _nome.GetHashCode() ^ _stazza.GetHashCode();
        }
        public static bool TryParse(string str, out Nave n)
        {
            bool creata = false;
            n = null;
            try
            {
                string[] parti = str.Split(',');
                n=new Nave(parti[0], Double.Parse(parti[1]), Int32.Parse(parti[2]), Boolean.Parse(parti[3]));
                creata=true;
            }
            catch(Exception e) 
            {
                //Console.WriteLine(e.Message);  evito questo messaggio per non generne troppi
                
            }
            return creata;
        }
        public static Nave Parse(string str)
        {
            Nave nuovaNave=null;
            bool creata = Nave.TryParse(str, out nuovaNave);
            if(!creata) 
            {
                throw new Exception("errore Nav");  //  To use the throw instruction a try-catch block should be invoked in program.cs
            }
            return nuovaNave;
        }
        public List<Posizione> Rotta { get; set; }
    }
}
