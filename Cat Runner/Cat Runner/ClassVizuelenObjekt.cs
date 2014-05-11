using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Cat_Runner
{
    public abstract class ClassVizuelenObjekt
    {
        public float X, Y, sirina, visina;
        public Animacija animacija;

        public abstract void Pridvizi();

        public void Crtaj(Graphics g)
        {
            animacija.Crtaj(g, X, Y, sirina, visina);
        }
    }
}
