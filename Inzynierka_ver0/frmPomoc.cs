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
    public partial class frmPomoc : Form
    {
        public frmPomoc()
        {
            InitializeComponent();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
