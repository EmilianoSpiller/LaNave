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
        Motore _motore1;
        Motore _motore2;
        public Nave() { }
        public Nave(string nome, double stazza, int velocità, bool varata, Comandante capitano, int cilindrataM1, int potenzaM1, string carburanteM1, int cilindrataM2, int potenzaM2, string carburanteM2)
        {
            _nome = nome;
            _stazza = stazza;
            _velocità = velocità;
            _varata = varata;
            _capitano = capitano;
            _motore1 = new Motore(cilindrataM1,potenzaM1,carburanteM1);   //with composition pattern the new instruction is inside the ship or rather the life cycles of the objects are the same
            _motore2 = new Motore(cilindrataM2, potenzaM2, carburanteM2); //with composition pattern the new instruction is inside the ship or rather the life cycles of the objects are the same
        }
        public Nave(string nome, double stazza, int velocità, int cilindrataM1, int potenzaM1, string carburanteM1, int cilindrataM2, int potenzaM2, string carburanteM2) : this(nome, stazza, velocità, false, null,cilindrataM1,potenzaM1, carburanteM1,cilindrataM2,potenzaM2, carburanteM2)
        { }

        public Nave(string nome, double stazza, int velocità, Comandante capitano, int cilindrataM1, int potenzaM1, string carburanteM1, int cilindrataM2, int potenzaM2, string carburanteM2) : this(nome, stazza, velocità, false, capitano,cilindrataM1, potenzaM1, carburanteM1, cilindrataM2, potenzaM2, carburanteM2)
        { _capitano = capitano; }
        public Nave(string nome, double stazza, int velocità, bool varata, int cilindrataM1, int potenzaM1, string carburanteM1, int cilindrataM2, int potenzaM2, string carburanteM2) : this(nome, stazza, velocità, varata, null, cilindrataM1, potenzaM1, carburanteM1, cilindrataM2, potenzaM2, carburanteM2)
        { }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public double Stazza
        {
            get; set;
        }
        public int Velocità
        {
            get; set;
        }
        public bool Varata
        {
            get; set;
        }
        public StatoNave Stato
        {
            get; set;
        }
        public Comandante Capitano
        {
            get; set;
        }
        public Motore Motore1
        {
            get { return _motore1; }
        }
        public Motore Motore2
        {
            get { return _motore2; }
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
                n=new Nave(parti[0], Double.Parse(parti[1]), Int32.Parse(parti[2]), Boolean.Parse(parti[3]), Int32.Parse(parti[4]), Int32.Parse(parti[5]), (parti[6]), Int32.Parse(parti[7]), Int32.Parse(parti[8]), (parti[9]));
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
