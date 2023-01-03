using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaNave
{
    internal class Motore
    {
        int _cilindrata;
        int _potenza;
        string _carburante;
        public Motore(int cilindrata, int potenza, string carburante)
        {
            _cilindrata = cilindrata;
            _potenza = potenza;
            _carburante = carburante;     
        }

        public int Cilindrata { get { return _cilindrata; } }
        public int Potenza { get { return _potenza; } }
        public string Carburante { get { return _carburante; } }

    }
}
