using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class GameData
    {
        //pamti sve o stanju igrice
        public SerializableTile[][] Tiles { get; set; }
        public int BrojMina { get; set; }
        public int BrojFlagova { get; set; }
        public int BrojPritisnutih { get; set; }
        public int Vreme { get; set; }
        public int N { get; set; }
        public int M { get; set; }
    }
}
