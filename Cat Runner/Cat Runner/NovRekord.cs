using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cat_Runner
{
    public partial class NovRekord : Form
    {
        public string ime;

        public NovRekord(bool mozeNazad)
        {
            InitializeComponent();
            btnOtkazi.Enabled = mozeNazad;
        }

        private void btnVnesi_Click(object sender, EventArgs e)
        {
            if (tbIme.Text.Trim().Length != 0 && !tbIme.Text.Contains(' '))
            {
                ime = tbIme.Text;
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                MessageBox.Show("Вашата игра не е зачувана");
            }
            btnOtkazi.Enabled = true;
            this.Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = !btnOtkazi.Enabled;
        }
    }
}
