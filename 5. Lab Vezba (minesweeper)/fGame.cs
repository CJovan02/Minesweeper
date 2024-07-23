using Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace _5.Lab_Vezba__minesweeper_
{
    public partial class fGame : Form
    {
        Tile[,] board;
        Difficulty difficulty = Difficulty.Begginer;
        int n, m, brojMina, brojFlagova;
        int pomN, pomM, pomBrojmina;
        int brojPritisnutih;
        int vreme;
        bool start;
        enum Difficulty
        {
            Begginer,
            Intermediate,
            Expert,
            Custom
        }
        public fGame()
        {
            InitializeComponent();
            NewGame();
        }

        void NewGame()
        {
            brojPritisnutih = brojFlagova = vreme = 0;
            lbl_timer.Text = "0";

            start = true;

            if (board != null)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Controls.Remove(board[i, j]);
                        board[i, j] = null;
                    }
                }
                board = null; 
            }

            UpdateDimensions();

            btn_emoji.BackgroundImage = ResizeImage(Properties.Resources.smile, 45, 45);
            lbl_brojMina.Text = brojMina.ToString();

            board = new Tile[n, m];
            int offset = 80;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    board[i, j] = new Tile
                    {
                        I = i,
                        J = j,
                        Location = new Point(j * 33, i * 33 + offset),
                        Size = new Size(35, 35),
                        BackColor = Color.White,
                        Status = TileStatus.Zatvoren,
                        Font = new Font("", 11),
                    };
                    board[i, j].Click += Tile_Click;
                    board[i, j].MouseUp += Tile_MouseUp;
                    Controls.Add(board[i, j]);
                }
            }

            this.Size = new Size(m * 35, offset + 23 + n * 35);
        }
        void LoadGame(GameData game)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Controls.Remove(board[i, j]);
                    board[i, j] = null;
                }
            }
            board = null;

            start = false;
            n = game.N;
            m = game.M;
            brojMina = game.BrojMina;
            brojPritisnutih = game.BrojPritisnutih;
            brojFlagova = game.BrojFlagova;
            vreme = game.Vreme;
            lbl_timer.Text = vreme.ToString();
            timer1.Enabled = true;


            btn_emoji.BackgroundImage = ResizeImage(Properties.Resources.smile, 45, 45);
            lbl_brojMina.Text = game.BrojMina.ToString();

            board = new Tile[n, m];
            int offset = 80;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    // Convert each SerializableTile object to Tile
                    board[i, j] = new Tile
                    {
                        // Set properties and fields from the SerializableTile object
                        // to the corresponding properties and fields in Tile
                        IsMine = game.Tiles[i][j].IsMine,
                        Status = game.Tiles[i][j].Status,
                        I = game.Tiles[i][j].I,
                        J = game.Tiles[i][j].J,
                        BrojSusednihMina = game.Tiles[i][j].BrojSusednihMina,
                        Location = new Point(j * 33, i * 33 + offset),
                        Size = new Size(35, 35),
                        BackColor = Color.White,
                        Font = new Font("", 11),
                    };
                    board[i, j].Click += Tile_Click;
                    board[i, j].MouseUp += Tile_MouseUp;

                    switch(board[i, j].Status)
                    {
                        case TileStatus.Zatvoren:
                            break;
                        case TileStatus.Otvoren1:
                            board[i, j].BackgroundImage = ResizeImage(Properties.Resources._1, 35, 35);
                            board[i, j].BackColor = Color.LightGray;
                            board[i, j].Enabled = false;
                            break;
                        case TileStatus.Otvoren2:
                            board[i, j].BackgroundImage = ResizeImage(Properties.Resources._2, 35, 35);
                            board[i, j].BackColor = Color.LightGray;
                            board[i, j].Enabled = false;
                            break;
                        case TileStatus.Otvoren3:
                            board[i, j].BackgroundImage = ResizeImage(Properties.Resources._3, 35, 35);
                            board[i, j].BackColor = Color.LightGray;
                            board[i, j].Enabled = false;
                            break;
                        case TileStatus.Otvoren4:
                            board[i, j].BackgroundImage = ResizeImage(Properties.Resources._4, 35, 35);
                            board[i, j].BackColor = Color.LightGray;
                            board[i, j].Enabled = false;
                            break;
                        case TileStatus.Otvoren5:
                            board[i, j].BackgroundImage = ResizeImage(Properties.Resources._5, 35, 35);
                            board[i, j].BackColor = Color.LightGray;
                            board[i, j].Enabled = false;
                            break;
                        case TileStatus.Otvoren6:
                            board[i, j].BackgroundImage = ResizeImage(Properties.Resources._6, 35, 35);
                            board[i, j].BackColor = Color.LightGray;
                            board[i, j].Enabled = false;
                            break;
                        case TileStatus.Otvoren7:
                            board[i, j].BackgroundImage = ResizeImage(Properties.Resources._7, 35, 35);
                            board[i, j].BackColor = Color.LightGray;
                            board[i, j].Enabled = false;
                            break;
                        case TileStatus.Otvoren8:
                            board[i, j].BackgroundImage = ResizeImage(Properties.Resources._8, 35, 35);
                            board[i, j].BackColor = Color.LightGray;
                            board[i, j].Enabled = false;
                            break;
                        case TileStatus.Flagovan:
                            board[i, j].BackgroundImage = ResizeImage(Properties.Resources.flag, 35, 35);
                            break;
                        case TileStatus.OtvorenPrazan:
                            board[i, j].BackColor = Color.LightGray;
                            board[i, j].Enabled = false;
                            break;
                        default:
                            break;
                    }

                    if (cheatToolStripMenuItem.Checked && board[i, j].IsMine)
                        board[i, j].BackColor = Color.Tan;
                    Controls.Add(board[i, j]);
                }
            }

            this.Size = new Size(m * 35, offset + 23 + n * 35);
        }

        void UpdateDimensions()
        {
            switch (difficulty)
            {
                case Difficulty.Begginer:
                    n = m = 9;
                    brojMina = 10;
                    break;
                case Difficulty.Intermediate:
                    n = m = 16;
                    brojMina = 40;
                    break;
                case Difficulty.Expert:
                    n = 16;
                    m = 30;
                    brojMina = 99;
                    break;
                case Difficulty.Custom:
                    n = pomN;
                    m = pomM;
                    brojMina = pomBrojmina;
                    break;
                default:
                    break;
            }
        }

        void PostaviMine(int brojMina, Tile pocetno)
        {
            var random = new Random();
            int totalTiles = n * m;
            int minesPlaced = 0;
            bool[,] visited = new bool[n, m];

            // Recursive function to place mines
            void PlaceMinesRecursive(int row, int col)
            {
                // Mark the tile as visited
                visited[row, col] = true;

                // Generate random indices for neighbors
                List<int> neighborIndexes = new List<int> { -1, 0, 1 };
                neighborIndexes = neighborIndexes.OrderBy(i => random.Next()).ToList();

                // Visit the neighbors
                foreach (int dx in neighborIndexes)
                {
                    foreach (int dy in neighborIndexes)
                    {
                        int newRow = row + dx;
                        int newCol = col + dy;

                        // Skip if out of bounds or already visited
                        if (newRow < 0 || newRow >= n || newCol < 0 || newCol >= m || visited[newRow, newCol])
                            continue;

                        // Place a mine at the neighbor with a certain probability
                        if (minesPlaced < brojMina && random.NextDouble() < 0.2 && board[newRow, newCol] != pocetno)
                        {
                            board[newRow, newCol].IsMine = true;
                            if (cheatToolStripMenuItem.Checked)
                                board[newRow, newCol].BackColor = Color.Tan;
                            minesPlaced++;
                        }

                        // Recurse on the neighbor
                        if (minesPlaced < brojMina)
                            PlaceMinesRecursive(newRow, newCol);
                    }
                }
            }

            // Start placing mines from a random tile
            int startRow = random.Next(n);
            int startCol = random.Next(m);
            PlaceMinesRecursive(startRow, startCol);
        } //The Recursive Backtracking algorithm

        Bitmap ResizeImage(Image image, int width, int height)
        {
            // Create a new bitmap with the desired dimensions
            Bitmap resizedBitmap = new Bitmap(width, height);

            // Create a graphics object from the resized bitmap
            using (Graphics graphics = Graphics.FromImage(resizedBitmap))
            {
                // Set the interpolation mode to high quality
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Draw the original image onto the resized bitmap
                graphics.DrawImage(image, 0, 0, width, height);
            }

            return resizedBitmap;
        }

        int BrojSusednihMina(Tile tile)
        {
            int brojSusednihMina = 0;

            for (int i = tile.I - 1; i <= tile.I + 1; i++)
            {
                for (int j = tile.J - 1; j <= tile.J + 1; j++)
                {
                    if (i < 0 || i >= n || j < 0 || j >= m)
                        continue;
                    if (board[i, j].IsMine)
                        brojSusednihMina++;
                }
            }

            return brojSusednihMina;
        }

        void OtvoriPolje(Tile tile)
        {
            if (tile.Status == TileStatus.Flagovan || tile.Enabled == false)
                return;
            tile.Enabled = false;
            brojPritisnutih++;
            tile.BackColor = Color.LightGray;
            switch (tile.BrojSusednihMina)
            {
                case 0:
                    tile.Status = TileStatus.OtvorenPrazan;
                    for (int i = tile.I - 1; i <= tile.I + 1; i++)
                    {
                        for (int j = tile.J - 1; j <= tile.J + 1; j++)
                        {
                            if (i < 0 || i >= n || j < 0 || j >= m)
                                continue;
                            OtvoriPolje(board[i, j]);
                        }
                    }
                    break;
                case 1:
                    tile.Status = TileStatus.Otvoren1;
                    tile.BackgroundImage = ResizeImage(Properties.Resources._1, 35, 35);
                    //tile.Text = "1"
                    break;
                case 2:
                    tile.Status = TileStatus.Otvoren2;
                    tile.BackgroundImage = ResizeImage(Properties.Resources._2, 35, 35);
                    //tile.Text = "2";
                    break;
                case 3:
                    tile.Status = TileStatus.Otvoren3;
                    tile.BackgroundImage = ResizeImage(Properties.Resources._3, 35, 35);
                    //tile.Text = "3";
                    break;
                case 4:
                    tile.Status = TileStatus.Otvoren4;
                    tile.BackgroundImage = ResizeImage(Properties.Resources._4, 35, 35);
                    //tile.Text = "4";
                    break;
                case 5:
                    tile.Status = TileStatus.Otvoren5;
                    tile.BackgroundImage = ResizeImage(Properties.Resources._5, 35, 35);
                    //tile.Text = "5";
                    break;
                case 6:
                    tile.Status = TileStatus.Otvoren6;
                    tile.BackgroundImage = ResizeImage(Properties.Resources._6, 35, 35);
                    //tile.Text = "6";
                    break;
                case 7:
                    tile.Status = TileStatus.Otvoren7;
                    tile.BackgroundImage = ResizeImage(Properties.Resources._7, 35, 35);
                    //tile.Text = "7";
                    break;
                case 8:
                    tile.Status = TileStatus.Otvoren8;
                    tile.BackgroundImage = ResizeImage(Properties.Resources._8, 35, 35);
                    //tile.Text = "8";
                    break;
                default:
                    return;
            }
            lbl_brojMina.Focus();
            CheckForWin();
        }

        void CheckForWin()
        {
            if(brojPritisnutih == n * m - brojMina)
            {
                timer1.Enabled = false;
                foreach (var el in board)
                {
                    if(el.IsMine)
                        el.Enabled = false;
                }
                btn_emoji.BackgroundImage = ResizeImage(Properties.Resources.win, 45, 45);
            }
        }

        void GameOver(Tile tile)
        {
            timer1.Enabled = false;
            btn_emoji.BackgroundImage = ResizeImage(Properties.Resources.ded, 45, 45);

            tile.BackColor = Color.Red;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //board[i, j].Enabled = false;
                    if (board[i, j].IsMine)
                        board[i, j].BackgroundImage = ResizeImage(Properties.Resources.mine, 35, 35);
                }
            }

            var f = new fBravo();
            f.ShowDialog();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    board[i, j].Enabled = false;
                }
            }
        }

        private void Tile_Click(object sender, EventArgs e)
        {
            Tile tile = (Tile)sender;

            if(start)
            {
                timer1.Enabled = true;
                PostaviMine(brojMina, tile);
                foreach (var el in board)
                {
                    el.BrojSusednihMina = BrojSusednihMina(el);
                }
                start = false;
            }

            if (tile.Status == TileStatus.Flagovan || tile.Enabled == false)
                return;

            if (tile.IsMine)
            {
                GameOver(tile);
                return;
            }

            OtvoriPolje(tile);
        }
        private void Tile_MouseUp(object sender, MouseEventArgs e) // event za desni klik
        {
            Tile tile = (Tile)sender;
            if(e.Button == MouseButtons.Right)
            {
                if (tile.Status == TileStatus.Flagovan)
                {
                    tile.Status = TileStatus.Zatvoren;
                    tile.BackgroundImage = null;
                    brojFlagova--;
                }
                else if (tile.Status == TileStatus.Zatvoren)
                {
                    Image img = Properties.Resources.flag;
                    img = ResizeImage(img, 35, 35);

                    tile.Status = TileStatus.Flagovan;
                    tile.BackgroundImage = img;
                    brojFlagova++;
                }
            }
            lbl_brojMina.Text = (brojMina - brojFlagova).ToString();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            vreme++;
            lbl_timer.Text = vreme.ToString();
        }
        private void begginerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            begginerToolStripMenuItem.Checked = true;
            itermediateToolStripMenuItem.Checked = false;
            expertToolStripMenuItem.Checked = false;
            customToolStripMenuItem.Checked = false;

            difficulty = Difficulty.Begginer;
            NewGame();
        }
        private void itermediateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            begginerToolStripMenuItem.Checked = false;
            itermediateToolStripMenuItem.Checked = true;
            expertToolStripMenuItem.Checked = false;
            customToolStripMenuItem.Checked = false;

            difficulty = Difficulty.Intermediate;
            NewGame();
        }
        private void expertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            begginerToolStripMenuItem.Checked = false;
            itermediateToolStripMenuItem.Checked = false;
            expertToolStripMenuItem.Checked = true;
            customToolStripMenuItem.Checked = false;

            difficulty = Difficulty.Expert;
            NewGame();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerializableTile[][] serializableMatrix = new SerializableTile[n][]; //jagged array - serijalizibilan je
            for (int i = 0; i < n; i++)
            {
                serializableMatrix[i] = new SerializableTile[m];
                for (int j = 0; j < m; j++)
                {
                    // Convert each Tile object to SerializableTile
                    serializableMatrix[i][j] = new SerializableTile
                    {
                        // Set properties and fields from the Tile object
                        // to the corresponding properties and fields in SerializableTile
                        IsMine = board[i, j].IsMine,
                        BrojSusednihMina = board[i, j].BrojSusednihMina,
                        I = board[i, j].I,
                        J = board[i, j].J,
                        Status = board[i, j].Status
                    };
                }
            }
            GameData game = new GameData()
            {
                BrojFlagova = brojFlagova,
                BrojMina = brojMina,
                M = m,
                N = n,
                BrojPritisnutih = brojPritisnutih,
                Tiles = serializableMatrix,
                Vreme = vreme
            };

            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(GameData));
                using (XmlTextWriter writer = new XmlTextWriter(sfd.FileName, Encoding.Unicode))
                {
                    serializer.Serialize(writer, game);
                }
            }
        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "xml files (*.xml)|*.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                GameData game;

                XmlSerializer serializer = new XmlSerializer(typeof(GameData));
                using (XmlTextReader reader = new XmlTextReader(ofd.FileName))
                {
                    game = (GameData)serializer.Deserialize(reader);
                }

                // Convert the SerializableTile objects back to Tile objects
                LoadGame(game);
            }
        }
        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            begginerToolStripMenuItem.Checked = false;
            itermediateToolStripMenuItem.Checked = false;
            expertToolStripMenuItem.Checked = false;
            customToolStripMenuItem.Checked = true;

            var f = new fCustom();
            f.ShowDialog();

            pomN = f.visina;
            pomM = f.sirina;
            pomBrojmina = f.brojMina;

            difficulty = Difficulty.Custom;
            NewGame();
        }
        private void cheatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cheatToolStripMenuItem.Checked)
            {
                cheatToolStripMenuItem.Checked = false;
                foreach (var mine in board)
                {
                    if(mine.IsMine)
                        mine.BackColor = Color.White;
                }
            }
            else
            {
                cheatToolStripMenuItem.Checked = true;
                foreach (var mine in board)
                {
                    if (mine.IsMine)
                        mine.BackColor = Color.Tan;
                }
            }
        }
        private void fGame_Resize(object sender, EventArgs e)
        {
            btn_emoji.Location = new Point((int)(this.Width / 2) - 33, 30);
            lbl_timer.Location = new Point((int)(this.Width) - 90, 43);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            vreme++;
            lbl_timer.Text = vreme.ToString();
        }
        private void btn_emoji_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
