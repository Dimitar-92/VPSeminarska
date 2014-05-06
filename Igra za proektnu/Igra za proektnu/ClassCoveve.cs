using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Igra_za_proektnu
{
    public class ClassCoveve : ClassVizuelenObiekt
    {
        public const int MaxVy = 16;
        public const int MaxSkoka = 2; // const ???
        public static float DolnaLinija;

        public float gx;
        public int Vy;
        public int brSkoka;
        public int poeni;
        public int krv;
        private bool skoka;

        public ClassCoveve()
        {
            Vy = 0;
            krv = 100;
            poeni = 0;
            skoka = false;
            sirina = 128;
            visina = 107;
            brSkoka = MaxSkoka;
            animacija = AllAnimations.main_run;
        }

        public void PocniSkok()
        {
            if (--brSkoka >= 0)
            {
                Vy = -MaxVy;
                skoka = true;
                animacija = AllAnimations.main_jump;
                animacija.Reset();
            }
        }

        public override void Pridvizi()
        {
            if (gx != X) X += (gx - X) * 0.25f;

            if (skoka) {
                Y += ++Vy;
                if (Y >= DolnaLinija)
                {
                    Y = DolnaLinija;
                    brSkoka = MaxSkoka;
                    animacija = AllAnimations.main_run;
                }
            }
        }
    }
}
