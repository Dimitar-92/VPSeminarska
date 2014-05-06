using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Igra_za_proektnu
{
    public abstract class ClassProtivnik : ClassVizuelenObiekt
    {
        public bool zaBrisenje;
        public bool keseBrise;

        public abstract bool Kontakt(ClassCoveve x);
        public abstract void Interakcija(ClassCoveve x);
    }
}
