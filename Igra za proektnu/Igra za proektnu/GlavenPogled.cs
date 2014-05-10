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
        private ClassHeroj Covece;
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

        private Graphics gpBlood;
        private Bitmap bmpBlood;
        private float currentBlood;

        private Graphics gpPoints;
        private Bitmap bmpPoints;

        public GlavenPogled()
        {
            InitializeComponent();
            takt = 0;
            AllAnimations.InicijalizacijaAnimacii();
            protivnici = new List<ClassProtivnik>(16);
            Covece = new ClassHeroj();
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
            ClassHeroj.DolnaLinija = panelIgra.Height - Covece.visina - 4;

            Covece.X = panelIgra.Width / 2;
            Covece.Y = ClassHeroj.DolnaLinija;

            panelIgra.Click += new EventHandler(priClick);
            panelIgra.DoubleClick += new EventHandler(priClick);
            panelIgra.MouseMove += new MouseEventHandler(DviziGluvce);
            
            bmpBlood = new Bitmap(pictureBlood.Width, pictureBlood.Height);
            gpBlood = Graphics.FromImage(bmpBlood);
            bmpBlood.MakeTransparent();
            gpBlood.DrawImage(Properties.Resources.frame, 0, 0, pictureBlood.Width, pictureBlood.Height);
            gpBlood.DrawImage(Properties.Resources.progress, 0, 0, pictureBlood.Width, pictureBlood.Height);
            gpBlood.DrawString(Covece.energija.ToString(), new System.Drawing.Font("Arial", 12), new SolidBrush(Color.White), pictureBlood.Width / 3, pictureBlood.Height / 3);  
            pictureBlood.Image = bmpBlood;
            currentBlood = (float)pictureBlood.Width / Covece.energija;

            bmpPoints = new Bitmap(picturePoints.Width, picturePoints.Height);
            gpPoints = Graphics.FromImage(bmpPoints);
            bmpPoints.MakeTransparent();
            gpPoints.DrawImage(Properties.Resources.apple, 0, 0, picturePoints.Width, picturePoints.Height);
            gpPoints.DrawString(Covece.poeni.ToString(), new System.Drawing.Font("Arial", 12), new SolidBrush(Color.White), picturePoints.Width / 2 - 10, picturePoints.Height / 3);        
            picturePoints.Image = bmpPoints;

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

            gpBlood.Clear(Color.Transparent);
            gpBlood.DrawImage(Properties.Resources.frame, 0, 0, pictureBlood.Width, pictureBlood.Height);
            gpBlood.DrawImage(Properties.Resources.progress, 0, 0, Covece.energija * currentBlood, pictureBlood.Height);
            gpBlood.DrawString(Covece.energija.ToString(), new System.Drawing.Font("Arial", 12), new SolidBrush(Color.White), pictureBlood.Width / 3, pictureBlood.Height / 3);  
            pictureBlood.Image = bmpBlood;

            gpPoints.Clear(Color.Transparent);
            gpPoints.DrawImage(Properties.Resources.apple, 0, 0, picturePoints.Width, picturePoints.Height);
            gpPoints.DrawString(Covece.poeni.ToString(), new System.Drawing.Font("Arial", 12), new SolidBrush(Color.White), picturePoints.Width / 2 - 10, picturePoints.Height / 3);
            picturePoints.Image = bmpPoints;

            takt++;
            if (takt == 6)
            {
                AllAnimations.Increment();
                takt = 0;
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            NovRekord rekord = new NovRekord();
            if (rekord.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(rekord.ime.Trim().Length != 0)
                {
                    int brojac = 0;
                    for (int i = 0; i < Properties.Settings.Default.players.Count;i++ )
                    {
                        string[] tmpList = Properties.Settings.Default.players[i].Split(' ');
                        if (tmpList[0].Trim().Equals(rekord.ime.Trim()))
                        {
                            Properties.Settings.Default.players[i] = string.Format("{0} {1}", tmpList[0], Covece.poeni.ToString());
                            break;
                        }
                        else
                        {
                            brojac++;
                        }
                    }
                    if(brojac.Equals(Properties.Settings.Default.players.Count))
                    {
                        Properties.Settings.Default.players.Add(string.Format("{0} {1}", rekord.ime, Covece.poeni.ToString()));
                            
                        MessageBox.Show("Успешно додавање!");
                    }
                    else
                    {
                    MessageBox.Show("Вашиот резултат е променет!");
                    }
                }   
                
            }
            else
            {
                MessageBox.Show("Неуспешно додавање!");
            }

            OsnovnaForma.osnovenPogled.Visible = true;
            OsnovnaForma.glavenPogled.Visible = false;
            OsnovnaForma.nacinIgra.Visible = false;
            OsnovnaForma.rekordi.Visible = false;

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