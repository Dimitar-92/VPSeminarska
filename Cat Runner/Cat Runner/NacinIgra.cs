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
    public partial class NacinIgra : UserControl
    {
        public NacinIgra()
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = new Bitmap("images/protivnik_1/run/3.png");
            pictureBox2.BackgroundImage = new Bitmap("images/protivnik_3/run/2.png");
            pictureBox3.BackgroundImage = new Bitmap("images/protivnik_5/run/2.png");
            pictureBox4.BackgroundImage = new Bitmap("images/main_character/jump/2.png");
            pictureBox5.BackgroundImage = new Bitmap("images/protivnik_4/run/1.png");
            pictureBox6.BackgroundImage = new Bitmap("images/protivnik_2/1.png");
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            OsnovnaForma.osnovenPogled.Visible = true;
            OsnovnaForma.glavenPogled.Visible = false;
            OsnovnaForma.nacinIgra.Visible = false;
            OsnovnaForma.rekordi.Visible = false;
        }
    }
}
