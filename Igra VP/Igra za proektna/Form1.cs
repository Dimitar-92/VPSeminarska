using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Igra_za_proektnu
{
    public partial class Form1 : Form
    {
        private int brznPozd = 7;
        //Thread NoviProtivnici;
        List<ClassProtivnik> protivnici;
        ClassCoveve Covece;
        Random rand;

        public Form1()
        {
            protivnici = new List<ClassProtivnik>(16);
            rand = new Random();
            Covece = new ClassCoveve();

            ClassCoveve.DolnaLinija = this.Height - Covece.Height - 30;
            ClassProtivnik.DolnaLinija = this.Height - 130;

            InitializeComponent();

            Covece.Location = new Point(Width / 2, ClassCoveve.DolnaLinija);
            Covece.MouseMove += new MouseEventHandler(DviziGluvceVrzObiekt);
            Covece.Click += new EventHandler(priClick);
            this.Controls.Add(Covece);
            Covece.BringToFront();
            //new Thread(new ThreadStart(DodadiNovProtivnik)).Start();
        }

        private void DodadiNovProtivnik(object obj, EventArgs a)
        {
            if (protivnici.Count > 4)
            {
                timer1.Interval = 256;
                return;
            }
            //Thread.Sleep(rand.Next(128, 2048));
            timer1.Interval = rand.Next(128, 2048);

            ClassProtivnik prot = new ClassProtivnik();
            prot.aaa = rand.Next(0, 3) == 0;
            if (prot.aaa)
            {
                prot.Image = null;
                prot.BackColor = Color.Red;
            }
            prot.Vx = rand.NextDouble() + 2;
            prot.X = this.Width;
            prot.Location = new Point(this.Width, ClassProtivnik.DolnaLinija);
            prot.MouseMove += new MouseEventHandler(DviziGluvceVrzObiekt);
            prot.Click += new EventHandler(priClick);
            protivnici.Add(prot);
            this.Controls.Add(prot);
            prot.BringToFront();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ClassProtivnik.DolnaLinija = this.Height - 130;
            ClassCoveve.DolnaLinija = this.Size.Height - Covece.Height - 30;
        }
        
  /**/  private void DviziGluvce(object sender, MouseEventArgs e)
        {
            Covece.Location = new Point(e.Location.X - Covece.Width/2, Covece.Location.Y);
        }
        
  /**/  private void DviziGluvceVrzObiekt(object sender, MouseEventArgs e)
        {
            Covece.Location = new Point(e.Location.X + ((Control)sender).Location.X - Covece.Width / 2, Covece.Location.Y);
        }

  
        private void PridviziProt(object sender, EventArgs e)
        {
            ClassProtivnik prot;
            for (int i = 0; i < protivnici.Count; ++i)
            {
                prot = protivnici[i];
                // void prot.Interakcija(ClassCovece);
                if (prot.Kontakt(Covece))
                {
                    //protivnici.Remove(prot);
                    Covece.brSkoka = ClassCoveve.MaxSkoka;
                    Covece.PocniSkok();
                    prot.Vx = brznPozd;
                    if (prot.aaa)
                    {
                        Covece.krv -= 1;
                        textBox1.Text = string.Format("{0} %", Covece.krv);
                    }
                    //if (prot.aaa) 
                        new Thread(new ParameterizedThreadStart(Ubivanje)).Start(prot);
                    //else prot.Size = new Size(prot.Size.Width, prot.Size.Height / 2);
                } else
                    if ((prot.X -= prot.Vx)+ prot.Width < 20 || prot.zaBrisenje) IzbrisiProt(prot);
                    else prot.Location = new Point((int)prot.X, ClassProtivnik.DolnaLinija);
            }
        }

        void Ubivanje(object obj)
        {
            ClassProtivnik prot = obj as ClassProtivnik;
            if (prot != null) prot.Ubivanje();
        }

        private void IzbrisiProt(ClassProtivnik prot)
        {
            protivnici.Remove(prot);
            this.Controls.Remove(prot);
            prot.Dispose();
        }

        private void priClick(object sender, EventArgs e)
        {
            Covece.PocniSkok();
        }
    }
}
