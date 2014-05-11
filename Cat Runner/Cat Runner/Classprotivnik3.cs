using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Cat_Runner
{
    public class ClassProtivnik3 : ClassProtivnik
    {
        private bool start;
        private int doBrisenje;
        private float Vx, Vy, DolnaLinija;

        public ClassProtivnik3(float x, float y, float vx, float dl)
        {
            Vy = -10;
            sirina = 80;
            visina = 80;
            start = true;
            doBrisenje = 32;
            ubien = izbrisi = false;
            animacija = AllAnimations.enemy_3_run;

            X = x;
            Y = y;
            Vx = vx;
            DolnaLinija = dl - visina - 16;
        }

        override public bool Kontakt(ClassHeroj Covece)
        {
            return Math.Abs(Covece.X + Covece.sirina * 0.5f - X - sirina * 0.5f) < 0.4f * (Covece.sirina + sirina) && Y + 8.0f < Covece.Y + Covece.visina && !start;
        }

        override public void Interakcija(ClassHeroj Covece)
        {
            Covece.brSkoka = ClassHeroj.MaxSkoka;
            Covece.PocniSkok();

            ubien = true;
            animacija = AllAnimations.enemy_3_dead;
            animacija.Restart();
            Covece.poeni += 2;
        }

        override public void Pridvizi()
        {
            if (ubien && animacija.Zavrsi() && --doBrisenje <= 0) izbrisi = true;   else
            if (start)
            {
                X += 8.0f;
                if ((Y += ++Vy) > DolnaLinija)
                {
                    //Y = DolnaLinija;
                    start = false;
                }
            } else
            if ((X -= Vx) + sirina < 20) ubien = izbrisi = true;
        }
    }
}
