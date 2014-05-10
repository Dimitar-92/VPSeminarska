using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Igra_za_proektnu
{
    public class ClassProtivnik3 : ClassProtivnik
    {
        private bool start;
        public float Vx, Vy, DolnaLinija;
        private System.Threading.Thread nitkaBrisi;

        public ClassProtivnik3()
        {
            sirina = 80;
            visina = 80;
            //Vy = -10;
            start = true;
            zaBrisenje = keseBrise = false;
            animacija = AllAnimations.enemy_3_run;
            nitkaBrisi = new System.Threading.Thread(new System.Threading.ThreadStart(CekajPaBrisi));
        }

        override public bool Kontakt(ClassCoveve Covece)
        {
            return Math.Abs(Covece.X + Covece.sirina * 0.5f - X - sirina * 0.5f) < 0.4f * (Covece.sirina + sirina) && Y + 8.0f < Covece.Y + Covece.visina && Covece.Vy > 0;
        }

        override public void Interakcija(ClassCoveve Covece)
        {
            Covece.brSkoka = ClassCoveve.MaxSkoka;
            Covece.PocniSkok();

            zaBrisenje = true;
            animacija = AllAnimations.enemy_3_dead;
            AllAnimations.enemy_3_dead.Reset();
            nitkaBrisi.Start();
            Covece.poeni += 20;
            //Form1.ff.textBoxPoeni.Text = string.Format("{0} $", Covece.poeni);
        }

        private void CekajPaBrisi()
        {
            System.Threading.Thread.Sleep(768);
            keseBrise = true;
            nitkaBrisi.Abort();
        }

        override public void Pridvizi()
        {
            if (start)
            {
                X += 8.0f;
                if ((Y += ++Vy) > DolnaLinija)
                {
                    //Y = DolnaLinija;
                    start = false;
                }
            } else
            if ((X -= Vx) + sirina < 20) zaBrisenje = keseBrise = true;
        }
    }
}
