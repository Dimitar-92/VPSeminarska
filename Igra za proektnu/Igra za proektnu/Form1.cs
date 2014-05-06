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
        public static int brznPozd = 12;
        //Thread NoviProtivnici;
        private List<ClassProtivnik> protivnici;
        private ClassCoveve Covece;
        private Graphics grafIgra;
        private Graphics grafBMP;
        private Bitmap bmp;
        public static Random rand;
        private System.Windows.Forms.Timer timer;
        private Thread nitkaDodadi;
        public static ClassProtivnik3 p;
        private int takt;
        
        public Form1()
        {
            InitializeComponent();

            takt = 0;
            AllAnimations.InicijalizacijaAnimacii();
            protivnici = new List<ClassProtivnik>(16);
            Covece = new ClassCoveve();
            rand = new Random();
            bmp = new Bitmap(this.Width, this.Height);
            grafBMP = Graphics.FromImage(bmp);

            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(GlavnaFunkcija);
            timer.Interval = 30;
            timer.Start();
            nitkaDodadi = new Thread(new ThreadStart(DodadiNovProtivnik));
            nitkaDodadi.Start();

            grafIgra = panelIgra.CreateGraphics();
            ClassCoveve.DolnaLinija = panelIgra.Height - Covece.visina - 4;
            
            Covece.X = panelIgra.Width / 2;
            Covece.Y = ClassCoveve.DolnaLinija;
        }

        void panelIgra_Disposed(object sender, EventArgs e)
        {
            timer.Stop();
            nitkaDodadi.Abort();
        }

        private void DodadiNovProtivnik()
        {
            ClassProtivnik prot;
            for (; ; )
            {
                if (rand.Next(0, 4) == 0) {
                    prot = new ClassProtivnik1();
                }
                else if (rand.Next(0, 4) == 1)
                {
                    prot = new ClassProtivnik2();
                }
                else if (rand.Next(0, 4) == 2)
                {
                    prot = new ClassProtivnik4();
                }
                else
                {
                    prot = new ClassProtivnik5();
                }
                prot.X = this.Width;
                prot.Y = panelIgra.Height - prot.visina - 4;
                protivnici.Add(prot);

                Thread.Sleep(rand.Next(128, 1024) * protivnici.Count);
            }
        }
        
  /**/  private void DviziGluvce(object sender, MouseEventArgs e)
        {
            Covece.gx = e.X - 0.5f * Covece.sirina;
        }

        private void priClick(object sender, EventArgs e)
        {
            Covece.PocniSkok();
        }

        private void GlavnaFunkcija(object sender, EventArgs e)
        {
            Covece.Pridvizi();

            grafBMP.DrawImage(Properties.Resources.Pozadina, 0.0f, 0.0f, panelIgra.Width, panelIgra.Height);
            ClassProtivnik prot;
            for (int i = 0; i < protivnici.Count; ++i)
            {
                prot = protivnici[i];
                prot.Pridvizi();
                prot.Crtaj(grafBMP);
                if (prot.keseBrise) {
                    protivnici.RemoveAt(i);  //  protivnici.Remove(prot);  pomalku optimalno !
                    //prot.Dispose();
                } else
                    if (!prot.zaBrisenje && prot.Kontakt(Covece))
                    {
                        prot.Interakcija(Covece);
                        if (p != null) protivnici.Add(p);
                    }
            }
            Covece.Crtaj(grafBMP);
            grafIgra.DrawImage(bmp, 0, 0);
            textBoxKrv.Text = string.Format("{0} %", Covece.krv);
            textBoxPoeni.Text = string.Format("{0} $", Covece.poeni);
            takt++;
            if (takt == 7)
            {
                AllAnimations.Increment();
                takt = 0;
            }
        }
    }
}
