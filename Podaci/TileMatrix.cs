using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Podaci
{
    [Serializable]
    public class TileMatrix
    {
        public static int N { get; set; }
        public static int M { get; set; }
        public Tile[,] Board { get; set; }

        public TileMatrix(int n, int m)
        {
            N = n;
            M = m;
            Board = new Tile[N, M];
        }

        public TileMatrix() { }

        public void Save(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Tile));
            using (XmlTextWriter writer = new XmlTextWriter(fileName, Encoding.Unicode))
            {
                foreach (var el in Board)
                {
                   serializer.Serialize(writer, el);
                }
            }
        }

        private static TileMatrix _instance = null;
        public static TileMatrix Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new TileMatrix(N, M);

                return _instance;
            }
        }
    }
}
