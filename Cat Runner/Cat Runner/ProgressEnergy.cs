using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cat_Runner
{
    public partial class ProgressEnergy : UserControl
    {

        private int vrednost;
        private float pom;
        private Bitmap bmpBlood;
        private Graphics g;

        public int Vrednost
        {
            get
            {
                return vrednost;
            }
            set
            {
                if (value >= 0 && value <= 100 && value != vrednost)
                {
                    vrednost = value;
                    Invalidate();
                }

            }
        }

        public ProgressEnergy()
        {
            vrednost = 0;
            this.DoubleBuffered = true;
            this.Size = new Size(140, 47);
        }

        protected override void  OnResize(EventArgs e)
        {
            bmpBlood = new Bitmap(this.Width, this.Height);
            bmpBlood.MakeTransparent();
            g = Graphics.FromImage(bmpBlood);
            pom = this.Width * 0.01f;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            this.DoubleBuffered = true;
            g.Clear(Color.Transparent);
            g.DrawImage(Properties.Resources.frame, 0, 0, this.Width, this.Height);
            g.DrawImage(Properties.Resources.progress, 0, 0, vrednost * pom, this.Height);
            g.DrawString(vrednost.ToString()+" %", new System.Drawing.Font("Arial", 12), new SolidBrush(Color.White), this.Width / 3, this.Height / 3);
            this.BackgroundImage = bmpBlood;
        }
    }
}
