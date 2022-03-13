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
    public partial class frmParametry : Form
    {
        public frmParametry()
        {
            InitializeComponent();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParametry_Load(object sender, EventArgs e)
        {
            txtPmax1.Text = frmWykres.CisnienieMaksymalne1.ToString();
            txtPmax2.Text = frmWykres.CisnienieMaksymalne2.ToString();
            txtPmax3.Text = frmWykres.CisnienieMaksymalne3.ToString();
            txtPmax4.Text = frmWykres.CisnienieMaksymalne4.ToString();
            txtPmax1skorygowane.Text= frmWykres.CisnienieMaksymalne1skorygowane.ToString();
            txtPmax2skorygowane.Text= frmWykres.CisnienieMaksymalne2skorygowane.ToString();
            txtPmax3skorygowane.Text= frmWykres.CisnienieMaksymalne3skorygowane.ToString();
            txtPmax4skorygowane.Text= frmWykres.CisnienieMaksymalne4skorygowane.ToString();
            txtTr1.Text = Math.Round(frmWykres.Tr1, 5).ToString();
            txtTr2.Text = Math.Round(frmWykres.Tr2, 5).ToString();
            txtTr3.Text = Math.Round(frmWykres.Tr3, 5).ToString();
            txtTr4.Text = Math.Round(frmWykres.Tr4, 5).ToString();
            txtU1.Text = Math.Round(frmWykres.U1,12).ToString();
            txtU2.Text = Math.Round(frmWykres.U2,12).ToString();
            txtU3.Text = Math.Round(frmWykres.U3,12).ToString();
            txtU4.Text = Math.Round(frmWykres.U4,12).ToString();
            txtTq.Text = Math.Round(frmWykres.Tq, 5).ToString();
            txtAlfa.Text = Math.Round(frmWykres.Alfa, 5).ToString();
            txtF.Text = Math.Round(frmWykres.F, 1).ToString();
            txtUSrednia.Text = Math.Round(frmWykres.USrednia,12).ToString();
            txtTh1.Text = frmWykres.Th1.ToString();
            txtTh2.Text = Math.Round(frmWykres.Th2, 5).ToString();
            txtTh3.Text = Math.Round(frmWykres.Th3, 5).ToString();
            txtTh4.Text = Math.Round(frmWykres.Th4, 5).ToString();
        }

        private void btnPomoc_Click(object sender, EventArgs e)
        {
            frmPomoc frmPomoc = new frmPomoc();
            frmPomoc.Show();
        }
    }
}
