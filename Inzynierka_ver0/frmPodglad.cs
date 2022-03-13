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
    public partial class frmPodglad : Form
    {
        public frmPodglad()
        {
            InitializeComponent();
        }

        private void btnWczytajPodglad_Click(object sender, EventArgs e)
        {
            string[] podglad = System.IO.File.ReadAllLines(txtPodgladSciezkaPliku.Text);
            for (int i = 0; i < 50; i++)
            { 
                txtPodgladPliku.Text += podglad[i] +"\r\n" ;
            }
            for(int i=0;i<50;i++)
            {
                txtNumeracja.Text += i+ "\r\n";
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtPodgladSciezkaPliku.Text = openFileDialog1.FileName;
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            frmPomoc frmPomoc = new frmPomoc();
            frmPomoc.Show();
        }
    }
}
