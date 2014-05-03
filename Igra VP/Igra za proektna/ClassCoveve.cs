using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Igra_za_proektnu
{
    public class ClassCoveve : PictureBox
    {
        public const int MaxVy = 16;
        public const int MaxSkoka = 2; // const ???

        public int Vy;
        public int brSkoka;
        public int krv;
        public static int DolnaLinija;
        private Timer timerSkok;

        public ClassCoveve()
        {
            timerSkok = new Timer();

            Vy = 0;
            krv = 100;
            brSkoka = MaxSkoka;
            Image = Properties.Resources.MAN_RUNNING;
            Size = new Size(128, 128);
            SizeMode = PictureBoxSizeMode.StretchImage;

            timerSkok.Enabled = true;
            timerSkok.Interval = 16;
            timerSkok.Stop();
            timerSkok.Tick += new EventHandler(Skokaj);

            ////////////////
        }

        public void PocniSkok()
        {
            if (--brSkoka >= 0)
            {
                Vy = -ClassCoveve.MaxVy;
                Image = Properties.Resources.skok;
                timerSkok.Start();
            }
        }

        private void Skokaj(object sender, EventArgs e)
        {
            int Y = Location.Y + ++Vy;
            if (Y >= DolnaLinija)
            {
                Location = new Point(Location.X, DolnaLinija);
                Image = Properties.Resources.MAN_RUNNING;
                brSkoka = MaxSkoka;
                timerSkok.Stop();
            }
            else Location = new Point(Location.X, Y);
        }
    }
}
