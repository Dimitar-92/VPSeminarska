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
        private System.Threading.Thread nitkaBrisi;

        public ClassProtivnik4()
        {
            sirina = 140;
            visina = 100;
            zaBrisenje = keseBrise = false;
            animacija = AllAnimations.enemy_4_run;
            Vx = (float)GlavenPogled.rand.NextDouble() * 4 + 4;
            nitkaBrisi = new System.Threading.Thread(new System.Threading.ThreadStart(CekajPaBrisi));
        }
        
        override public bool Kontakt(ClassHeroj Covece)
        {
            return Math.Abs(Covece.X + Covece.sirina * 0.5f - X - sirina * 0.5f) < 0.4f * (Covece.sirina + sirina) && Y + 8.0f < Covece.Y + Covece.visina && Y + 18.0f + Covece.Vy > Covece.Y + Covece.visina && Covece.Vy > 0;
        }

        override public void Interakcija(ClassHeroj Covece)
        {
            Covece.brSkoka = ClassHeroj.MaxSkoka;
            Covece.PocniSkok();

            zaBrisenje = true;
            //animacija = Properties.Resources.zombie_walking_T;
            nitkaBrisi.Start();
            Vx = GlavenPogled.brznPozd;
            Covece.poeni += 30;
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
