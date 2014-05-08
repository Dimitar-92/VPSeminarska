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
    public partial class IzberiSvojstva : UserControl
    {

        public IzberiSvojstva()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            //pbLikovi.Image = imgLstLikovi.Images[0];
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            //OsnovnaForma.referenca.Controls.Add(OsnovnaForma.osnovenPogled);
            //OsnovnaForma.osnovenPogled.BringToFront();
            //OsnovnaForma.izberiSvojstva.Visible = false;
            OsnovnaForma.osnovenPogled.Visible = true;
            OsnovnaForma.glavenPogled.Visible = false;
            OsnovnaForma.izberiSvojstva.Visible = false;

            //OsnovnaForma.tcPogledi.SelectedTab = OsnovnaForma.tcPogledi.TabPages[0];
        }

        private void radioGluvce_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGluvce.Checked)
            {
                GlavenPogled.gluvce = true;
            }
            else
            {
                GlavenPogled.gluvce = false;
            }
        }

    }
}
