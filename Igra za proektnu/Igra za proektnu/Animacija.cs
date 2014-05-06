using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Igra_za_proektnu
{
    public class Animacija
    {
        Bitmap[] images;
        int index;
        bool ne_stoi;

        public Animacija(string [] image_paths, bool ne_stoi)
        {
            images = new Bitmap[image_paths.Length];
            for (int i = 0; i < image_paths.Length; i++)
            {
                images[i] = new Bitmap(image_paths[i]);
            }
            index = 0;
            this.ne_stoi = ne_stoi;
        }

        public void Crtaj(Graphics g, float x, float y, float sirina, float visina)
        {
            g.DrawImage(images[index], x, y, sirina, visina);
        }

        public void SlednaSlika()
        {
            if (index+1 < images.Length)
            {
                index++;
            }
            else if (ne_stoi)
            {
                index = 0;
            }
        }

        public void Reset()
        {
            index = 0;
        }
    }
}
