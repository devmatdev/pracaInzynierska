using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inzynierka_ver0
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnWyjscie_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Na pewno?", "Kreator wykresów", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
            else
            {

            }
        }

        private void btnWykresy_Click(object sender, EventArgs e)
        {
            //frmWykresy frmWykresy = new frmWykresy();
            //frmWykresy.ShowDialog();
            btnLaduj.Visible = true;
            lblLiczba.Visible = true;
            updownIleWykresow.Visible = true;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLaduj_Click(object sender, EventArgs e)
        {
            
            string liczbaWykresow=updownIleWykresow.Value.ToString();
            int liczbaWykresowInt=Convert.ToInt32(liczbaWykresow);

            for (int i = 0; i < liczbaWykresowInt; i++)
            {
                frmWykres frmWykres = new frmWykres();
                frmWykres.Text = "Wykres " + (i + 1);
                frmWykres.Show();
            }
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            frmPomoc frmPomoc = new frmPomoc();
            frmPomoc.Show();
        }
    }
}
