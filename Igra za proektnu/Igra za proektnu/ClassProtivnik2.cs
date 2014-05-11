using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igra_za_proektnu
{
    class ClassProtivnik2 : ClassProtivnik
    {
        public ClassProtivnik2()
        {
            sirina = 70;
            visina = 80;
            ubien = izbrisi = false;
            animacija = AllAnimations.enemy_2;
        }
        
        public  override bool Kontakt(ClassHeroj Covece)
        {
            return Math.Abs(Covece.X + Covece.sirina * 0.5f - X - sirina * 0.5f) < 0.4f * (Covece.sirina + sirina) && Y + 8.0f < Covece.Y + Covece.visina;
        }

        public override void Interakcija(ClassHeroj Covece)
        {
            Covece.brSkoka = ClassHeroj.MaxSkoka;
            Covece.PocniSkok();
            Covece.energija -= 2;
        }

        public override void Pridvizi()
        {
            if ((X -= GlavenPogled.brznPozd) + sirina < 20) ubien = izbrisi = true;
        }
    }
}
