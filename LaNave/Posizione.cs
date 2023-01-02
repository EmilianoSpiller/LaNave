using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaNave
{
    internal class Posizione   // when "zero-to-many" association is required 
    {
        int _latitudine;
        int _longitudine;
        public int Latitudine { get; set; }
        public int Longitudine { get; set; }
        public Posizione() { }
        public Posizione(int lat, int lon) 
        {
            _latitudine = lat;
            _longitudine = lon;
        }
        public override string ToString()
        {
            return String.Format("lat:{0} - lon:{0}", _latitudine,_longitudine);
        }
        public static bool TryParse(string strPos, out Posizione nuovaPos)
        {
            bool creata = false;
            nuovaPos = null;
            try 
            {
                string[] strings = strPos.Split(',');
                nuovaPos= new Posizione(Int32.Parse(strings[0]), Int32.Parse(strings[1]));
                creata = true;
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e.ToString());
            }
            return creata;
        }

        public static Posizione Parse(string strPos) 
        {
            Posizione nuovaPos = null;
            if (!Posizione.TryParse(strPos, out nuovaPos))
            {
                throw new Exception("errore Pos");
            }
            return nuovaPos;
        }
    }
}
