﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cat_Runner
{
    public abstract class ClassProtivnik : ClassVizuelenObjekt
    {
        public bool ubien;
        public bool izbrisi;

        public abstract bool Kontakt(ClassHeroj x);
        public abstract void Interakcija(ClassHeroj x);
    }
}
