﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Specialized;

namespace Igra_za_proektnu
{
    public partial class OsnovnaForma : Form
    {
        public static GlavenPogled glavenPogled;
        public static OsnovenPogled osnovenPogled;
        public static NacinIgra nacinIgra;
        public static Rekordi rekordi;

        public OsnovnaForma()
        {
            InitializeComponent();

            if (Properties.Settings.Default.players == null)
            {
                Properties.Settings.Default.players = new StringCollection();
            }
            glavenPogled = new GlavenPogled();
            osnovenPogled = new OsnovenPogled();
            nacinIgra = new NacinIgra();
            rekordi = new Rekordi();

            this.Controls.Add(glavenPogled);
            this.Controls.Add(osnovenPogled);
            this.Controls.Add(nacinIgra);
            this.Controls.Add(rekordi);
/*
            tlSvojstva.SetRow(glavenPogled, 1);
            tlSvojstva.SetRow(osnovenPogled, 1);
            tlSvojstva.SetRow(nacinIgra, 1);
            tlSvojstva.SetRow(rekordi, 1);
            */
            osnovenPogled.Visible = true;
            glavenPogled.Visible = false;
            nacinIgra.Visible = false;
            rekordi.Visible = false;

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            
            Properties.Settings.Default.Save();
            
        }

        /*
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                if(glavenPogled != null && !glavenPogled.Visible)
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        */
    }
}
