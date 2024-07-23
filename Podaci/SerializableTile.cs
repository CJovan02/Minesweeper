using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    [Serializable]
    public class SerializableTile
    {
        //pamti ista svojstva koja ima Tile klasa
        public bool IsMine { get; set; }
        public TileStatus Status { get; set; }
        public int I { get; set; } // I, J - indeksi u matrici na kome se nalazi Tile
        public int J { get; set; }
        public int BrojSusednihMina { get; set; }
    }
}
