using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Igra_za_proektnu
{
    public class Animacija
    {
        Bitmap[] sliki;
        int index;
        bool ne_stoi;

        public Animacija(string [] pateki, bool ne_stoi)
        {
            sliki = new Bitmap[pateki.Length];
            for (int i = 0; i < pateki.Length; i++)
                sliki[i] = new Bitmap(pateki[i]);
            this.ne_stoi = ne_stoi;
            index = 0;
        }

        public void Crtaj(Graphics g, float x, float y, float sirina, float visina)
        {
            g.DrawImage(sliki[index], x, y, sirina, visina);
        }

        public void SlednaSlika()
        {
            if (index + 1 < sliki.Length)
            {
                ++index;
            }
            else if (ne_stoi)
            {
                index = 0;
            }
        }

        public void Restart()
        {
            index = 0;
        }

        public bool Zavrsi()
        {
            return !ne_stoi && index + 1 == sliki.Length;
        }
    }
}
