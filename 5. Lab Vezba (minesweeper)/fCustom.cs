using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Lab_Vezba__minesweeper_
{
    public partial class fCustom : Form
    {
        public int visina;
        public int sirina;
        public int brojMina;
        public fCustom()
        {
            InitializeComponent();
        }

        bool Check()
        {
            if(string.IsNullOrEmpty(txt_visina.Text))
                return false;

            if (Convert.ToInt32(txt_visina.Text) < 9)
                return false;

            if (string.IsNullOrEmpty(txt_sirina.Text))
                return false;

            if (Convert.ToInt32(txt_sirina.Text) < 9)
                return false;

            if (string.IsNullOrEmpty(txt_mine.Text))
                return false;

            if (Convert.ToInt32(txt_mine.Text) < 10)
                return false;

            return true;
        }

        private void txt_visina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            
        }
        private void txt_visina_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_visina.Text != "")
            {
                if (Convert.ToInt32(txt_visina.Text) < 9)
                    lbl_msg.Text = "Visina mora biti veca od 9";
                else
                    lbl_msg.Text = "";
            }
            else
                lbl_msg.Text = "Unesite visinu";
        }

        private void txt_sirina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txt_sirina_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_sirina.Text != "")
            {
                if (Convert.ToInt32(txt_sirina.Text) < 9)
                    lbl_msg.Text = "Sirina mora biti veca od 9";
                else
                    lbl_msg.Text = "";
            }
            else
                lbl_msg.Text = "Unesite sirinu";
        }

        private void txt_mine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_mine_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_mine.Text != "")
            {
                if (Convert.ToInt32(txt_mine.Text) < 10)
                    lbl_msg.Text = "Mine moraju biti vece od 10";
                else
                    lbl_msg.Text = "";
            }
            else
                lbl_msg.Text = "Unesite broj mina";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!Check())
                return;

            visina = Convert.ToInt32(txt_visina.Text);
            sirina = Convert.ToInt32(txt_sirina.Text);
            brojMina = Convert.ToInt32(txt_mine.Text);

            this.Close();
        }
    }
}
