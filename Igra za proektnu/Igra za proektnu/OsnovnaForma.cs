using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Igra_za_proektnu
{
    public partial class OsnovnaForma : Form
    {
        //GlavenPogled glavenPogled;

        public OsnovnaForma()
        {
            InitializeComponent();

            //glavenPogled = new GlavenPogled();
            //tlSvojstva.Controls.Add(glavenPogled);
            //tlSvojstva.SetRow(glavenPogled, 1);

            izberiSvojstva.Visible = false;
            osnovenPogled.Visible = true;
            glavenPogled.Visible = false;

        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            MessageBox.Show("Stoooop");
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                //if(glavenPogled != null && !glavenPogled.Visible)
                //cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

    }
}
