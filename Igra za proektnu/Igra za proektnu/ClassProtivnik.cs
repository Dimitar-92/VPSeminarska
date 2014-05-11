using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igra_za_proektnu
{
    public abstract class ClassProtivnik : ClassVisualObiect
    {
        public bool zaBrisenje;
        public bool keseBrise;

        public abstract bool Kontakt(ClassHeroj x);
        public abstract void Interakcija(ClassHeroj x);
    }
}
