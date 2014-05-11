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
        private Timer timer;
        public static ClassProtivnik generiranProtivnik;
        private int taktAnimacija;
        private int taktGeneriraj;
        private Bitmap Pozadina;
        public int pozicija;

        public GlavenPogled()
        {
            InitializeComponent();
            AllAnimations.InicijalizirajAnimacii();
            protivnici = new List<ClassProtivnik>(64);
            Pozadina = new Bitmap(new Bitmap("images/background/Pozadina.png"), new Size(1872, 397));
            label3.Image = new Bitmap(new Bitmap("images/apple.gif"), label3.Width, label3.Height);
            bmp = new Bitmap(panelIgra.Width, panelIgra.Height);
            grafBMP = Graphics.FromImage(bmp);
            Covece = new ClassHeroj();
            rand = new Random();

            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(GlavnaFunkcija);
            timer.Interval = 30;

            grafIgra = panelIgra.CreateGraphics();

            panelIgra.Click += new EventHandler(priClick);
            panelIgra.DoubleClick += new EventHandler(priClick);
            panelIgra.MouseMove += new MouseEventHandler(DviziGluvce);
        }

        private void DodadiNovProtivnik()
        {
            int i;
            ClassProtivnik prot;
            i = rand.Next(0, 100);
            if (i >= 0 && i < 20)
            {
                prot = new ClassProtivnik1();
            }
            else if (i >= 20 && i < 40)
            {
                prot = new ClassProtivnik2();
            }
            else if (i >= 40 && i < 60)
            {
                prot = new ClassProtivnik5();
            }
            else
            {
                prot = new ClassProtivnik4();
            }

            prot.X = panelIgra.Width;
            prot.Y = panelIgra.Height - prot.visina - 4;
            protivnici.Add(prot);
        }

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
            if ((pozicija -= brznPozd) < -930) pozicija = 0;
            grafBMP.DrawImage(Pozadina, pozicija, 0, Pozadina.Width, panelIgra.Height);

            ClassProtivnik prot;
            for (int i = protivnici.Count - 1; i >= 0; --i)
            {
                prot = protivnici[i];
                prot.Pridvizi();
                prot.Crtaj(grafBMP);
                if (prot.izbrisi)
                {
                    protivnici.RemoveAt(i);  //  protivnici.Remove(prot);  pomalku optimalno !
                    //prot.Dispose();
                }
                else
                    if (!prot.ubien && prot.Kontakt(Covece))
                    {
                        prot.Interakcija(Covece);
                        if (generiranProtivnik != null)
                        {
                            protivnici.Add(generiranProtivnik);
                            generiranProtivnik = null;
                        }
                    }
            }
            Covece.Pridvizi();
            Covece.Crtaj(grafBMP);

            grafIgra.DrawImage(bmp, 0, 0);

            label3.Text = Covece.poeni.ToString();
            if (Covece.energija <= 0)
            {
                progressEnergy1.Vrednost = 0;
                btnNazad_Click(null, null);
            }
            progressEnergy1.Vrednost = Covece.energija;
            
            if (--taktAnimacija <= 0)
            {
                AllAnimations.OsveziAnimacii();
                taktAnimacija = 6;
            }
            if (--taktGeneriraj <= 0)
            {
                DodadiNovProtivnik();
                taktGeneriraj = rand.Next(10 * protivnici.Count);
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            timer.Stop();
            NovRekord rekord = new NovRekord(Covece.energija > 0);
            if (rekord.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (rekord.ime != null && rekord.ime.Trim().Length != 0)
                {
                    int brojac = 0;
                    for (int i = 0; i < Properties.Settings.Default.players.Count; i++)
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
                    if (brojac.Equals(Properties.Settings.Default.players.Count))
                    {
                        Properties.Settings.Default.players.Add(string.Format("{0} {1}", rekord.ime, Covece.poeni.ToString()));

                        MessageBox.Show("Успешно додавање!");
                    }
                    else
                    {
                        MessageBox.Show("Вашиот резултат е променет!");
                    }
                }

                OsnovnaForma.osnovenPogled.Visible = true;
                OsnovnaForma.glavenPogled.Visible = false;
                OsnovnaForma.nacinIgra.Visible = false;
                OsnovnaForma.rekordi.Visible = false;
            }
            else timer.Start();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                pozicija = 0;
                taktGeneriraj = 0;
                taktAnimacija = 6;

                ClassHeroj.DolnaLinija = panelIgra.Height - Covece.visina - 4;
                Covece.X = panelIgra.Width / 2;
                Covece.Y = ClassHeroj.DolnaLinija;
                Covece.energija = 100;
                Covece.poeni = 0;
                timer.Start();

                label3.Text = "0 $";
                progressEnergy1.Vrednost = 100;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            grafIgra.DrawImage(bmp, 0, 0);
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