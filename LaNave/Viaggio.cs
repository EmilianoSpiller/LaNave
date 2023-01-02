using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaNave
{
    internal class Viaggio  // When a m2m relation is involved
    {
        int _idViaggio;
        DateTime _dataPartenza;
        DateTime _dataArrivo;
        double _miglia;
        Nave _imbarcazione;
        Comandante _capitano;
    }
}
