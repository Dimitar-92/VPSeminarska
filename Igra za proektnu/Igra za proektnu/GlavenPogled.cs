using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Igra_za_proektnu
{
    public partial class GlavenPogled : UserControl
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
        private Bitmap Pozadina;
        public int pozicija;

        public static bool gluvce;

        public GlavenPogled()
        {
            InitializeComponent();
            takt = 0;
            AllAnimations.InicijalizacijaAnimacii();
            protivnici = new List<ClassProtivnik>(16);
            Covece = new ClassCoveve();
            rand = new Random();/*
            panelIgra.Size = new Size(972, 397);
            MessageBox.Show(panelIgra.Width+" "+ panelIgra.Height);*/
            bmp = new Bitmap(panelIgra.Width, panelIgra.Height);
            grafBMP = Graphics.FromImage(bmp);
            Pozadina = new Bitmap(new Bitmap("images/backgorund/Pozadina.png"), new Size(1872, 397));
            pozicija = 0;

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

            panelIgra.Click += new EventHandler(priClick);
            panelIgra.DoubleClick += new EventHandler(priClick);
            panelIgra.MouseMove += new MouseEventHandler(DviziGluvce);
        }

        private void DodadiNovProtivnik()
        {
            ClassProtivnik prot;
            for (; ; )
            {
                int i = rand.Next(0,100);
                if(i>=0 && i<20)
                {
                    prot = new ClassProtivnik1();
                }
                else if(i>=20 && i<50)
                {
                    prot = new ClassProtivnik2();
                }
                else if(i>=50 && i<70)
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

        /**/
        private void DviziGluvce(object sender, MouseEventArgs e)
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

            grafBMP.DrawImage(Pozadina, pozicija, panelIgra.Location.Y, Pozadina.Width, panelIgra.Height);
            if ((pozicija -= brznPozd) < -930) pozicija = 0;
            ClassProtivnik prot;
            for (int i = 0; i < protivnici.Count; ++i)
            {
                prot = protivnici[i];
                prot.Pridvizi();
                prot.Crtaj(grafBMP);
                if (prot.keseBrise)
                {
                    protivnici.RemoveAt(i);  //  protivnici.Remove(prot);  pomalku optimalno !
                    //prot.Dispose();
                }
                else
                    if (!prot.zaBrisenje && prot.Kontakt(Covece))
                    {
                        prot.Interakcija(Covece);
                        if (p != null) protivnici.Add(p);
                    }
            }
            Covece.Crtaj(grafBMP);
            grafIgra.DrawImage(bmp, panelIgra.Location.X, panelIgra.Location.Y);
            //textBoxKrv.Text = string.Format("{0} %", Covece.krv);
            //textBoxPoeni.Text = string.Format("{0} $", Covece.poeni);
            takt++;
            if (takt == 6)
            {
                AllAnimations.Increment();
                takt = 0;
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            OsnovnaForma.izberiSvojstva.Visible = false;
            OsnovnaForma.osnovenPogled.Visible = true;
            OsnovnaForma.glavenPogled.Visible = false;

            panelIgra.Dispose();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            if (this.Visible)
            {
                timer.Start();
                nitkaDodadi = new Thread(new ThreadStart(DodadiNovProtivnik));
                nitkaDodadi.Start();
            }
            else
            {
                timer.Stop();
                nitkaDodadi.Abort();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            bmp = new Bitmap(panelIgra.Width, panelIgra.Height);
            grafBMP = Graphics.FromImage(bmp);
            grafIgra = panelIgra.CreateGraphics();
        }
        

    }
}