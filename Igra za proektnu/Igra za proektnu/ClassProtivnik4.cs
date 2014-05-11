using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Igra_za_proektnu
{
    public class ClassProtivnik4 : ClassProtivnik
    {
        private float Vx;
        private System.Threading.Thread nitkaBrisi;/////////////

        public ClassProtivnik4()
        {
            sirina = 140;
            visina = 100;
            ubien = izbrisi = false;
            animacija = AllAnimations.enemy_4_run;
            Vx = (float)GlavenPogled.rand.NextDouble() * 4 + 4;
            nitkaBrisi = new System.Threading.Thread(new System.Threading.ThreadStart(CekajPaBrisi));
        }

        public override bool Kontakt(ClassHeroj Covece)
        {
            return Math.Abs(Covece.X + Covece.sirina * 0.5f - X - sirina * 0.5f) < 0.4f * (Covece.sirina + sirina) && Y + 8.0f < Covece.Y + Covece.visina && Y + 18.0f + Covece.Vy > Covece.Y + Covece.visina && Covece.Vy > 0;
        }

        public override void Interakcija(ClassHeroj Covece)
        {
            Covece.brSkoka = ClassHeroj.MaxSkoka;
            Covece.PocniSkok();
            Covece.poeni += 5;

            ubien = true;
            animacija = AllAnimations.enemy_4_dead;
            animacija.Restart();
            nitkaBrisi.Start();
            Vx = GlavenPogled.brznPozd;
        }

        private void CekajPaBrisi()
        {
            System.Threading.Thread.Sleep(768);
            izbrisi = true;
            nitkaBrisi.Abort();
        }

        public override void Pridvizi()
        {
            if ((X -= Vx) + sirina < 20) ubien = izbrisi = true;
        }
    }
}
