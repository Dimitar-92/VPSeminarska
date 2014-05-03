using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Igra_za_proektnu
{
    public class ClassProtivnik : PictureBox
    {
        public double X;
        public double Vx;
        public bool zaBrisenje;
        public bool keseBrise;
        public bool aaa;
        public static int DolnaLinija = 0;

        public ClassProtivnik()
        {
            keseBrise = false;
            zaBrisenje = false;
            Image = Properties.Resources.zombie;
            BackColor = Color.Transparent;
            Size = new Size(100, 100);
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        internal void Ubivanje()
        {
            keseBrise = true;
            //BringToFront();
            if (aaa) Image = Properties.Resources.Eksplozija;
            else Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
            System.Threading.Thread.Sleep(1024);
            zaBrisenje = true;
        }

        internal bool Kontakt(ClassCoveve Covece)
        {
            return !keseBrise && Math.Abs(Covece.Location.X - X + 14) < 81.0 && DolnaLinija - Covece.Location.Y < 100  && (DolnaLinija - Covece.Location.Y > 50 && Covece.Vy > 0 || aaa);
        }
    }
}
