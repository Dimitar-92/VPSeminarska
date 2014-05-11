using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Igra_za_proektnu
{
    public partial class Rekordi : UserControl
    {
        public Rekordi()
        {
            InitializeComponent();
            if (Properties.Settings.Default.players.Count != 0)
            {
                foreach (string s in Properties.Settings.Default.players)
                {
                    string[] tmpList = s.Split(' ');
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(tmpList[0]);
                    lvi.SubItems.Add(tmpList[1]);
                    lvPlayers.Items.Add(lvi);
                }
            }
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Properties.Settings.Default.players.Count > lvPlayers.Items.Count)
            {
                for (int index = lvPlayers.Items.Count; index < Properties.Settings.Default.players.Count; index++)
                {
                    string[] tmpList = Properties.Settings.Default.players[index].Split(' ');
                    ListViewItem lvi = new ListViewItem();
                    lvi.SubItems.Add(tmpList[0]);
                    lvi.SubItems.Add(tmpList[1]);
                    lvPlayers.Items.Add(lvi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OsnovnaForma.osnovenPogled.Visible = true;
            OsnovnaForma.glavenPogled.Visible = false;
            OsnovnaForma.nacinIgra.Visible = false;
            OsnovnaForma.rekordi.Visible = false;
        }
    }
}
