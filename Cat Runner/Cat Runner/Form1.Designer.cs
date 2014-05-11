namespace Igra_za_proektnu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxKrv = new System.Windows.Forms.TextBox();
            this.textBoxPoeni = new System.Windows.Forms.TextBox();
            this.panelIgra = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxKrv
            // 
            this.textBoxKrv.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxKrv.Enabled = false;
            this.textBoxKrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKrv.ForeColor = System.Drawing.Color.Lime;
            this.textBoxKrv.Location = new System.Drawing.Point(12, 12);
            this.textBoxKrv.Name = "textBoxKrv";
            this.textBoxKrv.Size = new System.Drawing.Size(122, 44);
            this.textBoxKrv.TabIndex = 2;
            this.textBoxKrv.Text = "100 %";
            this.textBoxKrv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPoeni
            // 
            this.textBoxPoeni.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxPoeni.Enabled = false;
            this.textBoxPoeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPoeni.ForeColor = System.Drawing.Color.Lime;
            this.textBoxPoeni.Location = new System.Drawing.Point(140, 12);
            this.textBoxPoeni.Name = "textBoxPoeni";
            this.textBoxPoeni.Size = new System.Drawing.Size(122, 44);
            this.textBoxPoeni.TabIndex = 2;
            this.textBoxPoeni.Text = "100 %";
            this.textBoxPoeni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelIgra
            // 
            this.panelIgra.Location = new System.Drawing.Point(13, 63);
            this.panelIgra.Name = "panelIgra";
            this.panelIgra.Size = new System.Drawing.Size(767, 391);
            this.panelIgra.TabIndex = 3;
            this.panelIgra.Click += new System.EventHandler(this.priClick);
            this.panelIgra.DoubleClick += new System.EventHandler(this.priClick);
            this.panelIgra.Disposed += new System.EventHandler(panelIgra_Disposed);
            this.panelIgra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DviziGluvce);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.panelIgra);
            this.Controls.Add(this.textBoxPoeni);
            this.Controls.Add(this.textBoxKrv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.TextBox textBoxKrv;
        public System.Windows.Forms.TextBox textBoxPoeni;
        private System.Windows.Forms.Panel panelIgra;
    }
}

