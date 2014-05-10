using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Igra_za_proektnu
{
    public class ClassProtivnik2 : ClassProtivnik
    {
        private float Vx;
        private System.Threading.Thread nitkaBrisi;

        public ClassProtivnik2()
        {
            sirina = 80;
            visina = 80;
            zaBrisenje = keseBrise = false;
            animacija = AllAnimations.enemy_2_stand;
            Vx = (float)GlavenPogled.rand.NextDouble() * 4 + 4;
            nitkaBrisi = new System.Threading.Thread(new System.Threading.ThreadStart(CekajPaBrisi));
        }

        override public bool Kontakt(ClassHeroj Covece)
        {
            return Math.Abs(Covece.X + Covece.sirina * 0.5f - X - sirina * 0.5f) < 0.4f * (Covece.sirina + sirina) && Y + 8.0f < Covece.Y + Covece.visina;
        }

        override public void Interakcija(ClassHeroj Covece)
        {
            Covece.brSkoka = ClassHeroj.MaxSkoka;
            Covece.PocniSkok();

            zaBrisenje = true;
            animacija = AllAnimations.enemy_2_dead;
            nitkaBrisi.Start();
            Vx = GlavenPogled.brznPozd;
            Covece.energija -= 15;
            //Form1.ff.textBoxKrv.Text = string.Format("{0} %", Covece.krv);
        }

        private void CekajPaBrisi()
        {
            System.Threading.Thread.Sleep(754);
            keseBrise = true;
            nitkaBrisi.Abort();
        }

        override public void Pridvizi()
        {
            if ((X -= Vx) + sirina < 20) zaBrisenje = keseBrise = true;
        }
    }
}
