using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cat_Runner
{
    public partial class OsnovenPogled : UserControl
    {
        public OsnovenPogled()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void btnPocni_Click(object sender, EventArgs e)
        {
            OsnovnaForma.osnovenPogled.Visible = false;
            OsnovnaForma.glavenPogled.Visible = true;
            OsnovnaForma.nacinIgra.Visible = false;
            OsnovnaForma.rekordi.Visible = false;
        }

        private void btnNacinIgra_Click(object sender, EventArgs e)
        {
            OsnovnaForma.osnovenPogled.Visible = false;
            OsnovnaForma.glavenPogled.Visible = false;
            OsnovnaForma.nacinIgra.Visible = true;
            OsnovnaForma.rekordi.Visible = false;
        }

        private void btnRekordi_Click(object sender, EventArgs e)
        {
            OsnovnaForma.osnovenPogled.Visible = false;
            OsnovnaForma.glavenPogled.Visible = false;
            OsnovnaForma.rekordi.Visible = true;
            OsnovnaForma.nacinIgra.Visible = false;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
