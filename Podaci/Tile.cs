using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Podaci
{
    [Serializable]
    public class Tile : Button
    {
        public bool IsMine { get; set; }
        public TileStatus Status { get; set; }
        public int I { get; set; } // I, J - indeksi u matrici na kome se nalazi Tile
        public int J { get; set; }
        public int BrojSusednihMina { get; set; }
        
    }
}
