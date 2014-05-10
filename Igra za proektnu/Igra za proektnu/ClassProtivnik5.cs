using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Igra_za_proektnu
{
    public class ClassProtivnik5 : ClassProtivnik
    {
        private float Vx;
        private System.Threading.Thread nitkaBrisi;

        public ClassProtivnik5()
        {
            sirina = 96;
            visina = 87;
            zaBrisenje = keseBrise = false;
            animacija = AllAnimations.enemy_5_run;
            Vx = (float)GlavenPogled.rand.NextDouble() * 4 + GlavenPogled.brznPozd;
            nitkaBrisi = new System.Threading.Thread(new System.Threading.ThreadStart(CekajPaBrisi));
        }
        
        override public bool Kontakt(ClassCoveve Covece)
        {
            return Math.Abs(Covece.X + Covece.sirina * 0.5f - X - sirina * 0.5f) < 0.4f * (Covece.sirina + sirina) && Y + 8.0f < Covece.Y + Covece.visina && Y + 18.0f + Covece.Vy > Covece.Y + Covece.visina && Covece.Vy > 0;
        }

        override public void Interakcija(ClassCoveve Covece)
        {
            Covece.brSkoka = ClassCoveve.MaxSkoka;
            Covece.PocniSkok();

            Y -= 50;
            
            sirina = 150;
            visina = 140;
            zaBrisenje = true;
            AllAnimations.enemy_5_dead.Reset();
            animacija = AllAnimations.enemy_5_dead;
            nitkaBrisi.Start();
            Vx = GlavenPogled.brznPozd;
            Covece.poeni += 15;
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
            if ((X -= Vx) + sirina < 20) zaBrisenje = keseBrise = true;
        }
    }
}
