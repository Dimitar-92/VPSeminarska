using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Cat_Runner
{
    public class ClassProtivnik5 : ClassProtivnik
    {
        private float Vx;

        public ClassProtivnik5()
        {
            sirina = 96;
            visina = 87;
            ubien = izbrisi = false;
            animacija = AllAnimations.enemy_5_run;
            Vx = (float)GlavenPogled.rand.NextDouble() * 4 + 4 + GlavenPogled.brznPozd;
        }

        public override bool Kontakt(ClassHeroj covece)
        {
            return Math.Abs(covece.X + covece.sirina * 0.5f - X - sirina * 0.5f) < (covece.sirina + sirina) * 0.5f && Y < covece.Y + covece.visina;
        }

        public override void Interakcija(ClassHeroj Covece)
        {
            Covece.brSkoka = ClassHeroj.MaxSkoka;
            Covece.PocniSkok();

            Y -= 50;            
            sirina = 150;
            visina = 140;
            ubien = true;
            Vx = GlavenPogled.brznPozd;
            animacija = AllAnimations.enemy_5_dead;
            animacija.Restart();
            
            Covece.energija -= 5;
        }

        public override void Pridvizi()
        {
            if (ubien && animacija.Zavrsi()) izbrisi = true;    else
            if ((X -= Vx) + sirina < 20) ubien = izbrisi = true;
        }
    }
}
