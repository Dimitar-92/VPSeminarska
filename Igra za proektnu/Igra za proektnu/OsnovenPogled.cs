using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Igra_za_proektnu
{
    public partial class OsnovenPogled : UserControl
    {
        //private NewProgressBar pbOsnova;//


        public OsnovenPogled()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            /* pbOsnova = new NewProgressBar();
            pbOsnova.ProgressBoja = Color.Pink;
            pbOsnova.Vrednost = 200;
            pbOsnova.X = Width / 3;
            pbOsnova.Y = Height / 4;

            Invalidate();*/
        }

        private void btnPocni_Click(object sender, EventArgs e)
        {
            //OsnovnaForma.referenca.Controls.Add(OsnovnaForma.izberiSvojstva);
            //OsnovnaForma.izberiSvojstva.BringToFront();
            //OsnovnaForma.referenca.Controls.Remove(this);

            OsnovnaForma.izberiSvojstva.Visible = false;
            OsnovnaForma.osnovenPogled.Visible = false;
            OsnovnaForma.glavenPogled.Visible = true;
        }

        private void btnIzberiSvojstva_Click(object sender, EventArgs e)
        {
            OsnovnaForma.izberiSvojstva.Visible = true;
            OsnovnaForma.osnovenPogled.Visible = false;
            OsnovnaForma.glavenPogled.Visible = false;
        }

        private void btnNacinIgra_Click(object sender, EventArgs e)
        {

        }

        private void btnRekordi_Click(object sender, EventArgs e)
        {

        }
    }
}
