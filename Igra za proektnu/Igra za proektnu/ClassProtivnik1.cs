using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Igra_za_proektnu
{
    public class ClassProtivnik1 : ClassProtivnik
    {
        private float Vx;

        public ClassProtivnik1()
        {
            sirina = 200;
            visina = 143;
            ubien = izbrisi = false;
            animacija = AllAnimations.enemy_1_run;
            Vx = (float)GlavenPogled.rand.NextDouble() * 4 + 4;
        }

        override public bool Kontakt(ClassHeroj Covece)
        {
            return Math.Abs(Covece.X + Covece.sirina * 0.5f - X - sirina * 0.5f) < 0.4f * (Covece.sirina + sirina) && Y + 8.0f < Covece.Y + Covece.visina && Y + 18.0f + Covece.Vy > Covece.Y + Covece.visina && Covece.Vy > 0;
        }

        override public void Interakcija(ClassHeroj Covece)
        {
            Covece.brSkoka = ClassHeroj.MaxSkoka;
            Covece.PocniSkok();
            Covece.poeni += 10;

            GlavenPogled.generiranProtivnik = new ClassProtivnik3(X, Y, Vx, Y + visina);

            sirina = 250;
            visina = 175;
            ubien = true;
            animacija = AllAnimations.enemy_1_dead;
            animacija.Restart();
        }

        override public void Pridvizi()
        {
            if (ubien && (Vx += 0.25f) > GlavenPogled.brznPozd) izbrisi = true;
            if ((X -= Vx) + sirina < 20) ubien = izbrisi = true;
        }
    }
}
