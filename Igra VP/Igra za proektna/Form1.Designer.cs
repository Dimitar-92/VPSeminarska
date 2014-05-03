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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbPozadina = new System.Windows.Forms.PictureBox();
            this.timerDviziProtivnik = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadina)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPozadina
            // 
            this.pbPozadina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPozadina.Image = ((System.Drawing.Image)(resources.GetObject("pbPozadina.Image")));
            this.pbPozadina.Location = new System.Drawing.Point(0, 0);
            this.pbPozadina.Name = "pbPozadina";
            this.pbPozadina.Size = new System.Drawing.Size(792, 466);
            this.pbPozadina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPozadina.TabIndex = 1;
            this.pbPozadina.TabStop = false;
            this.pbPozadina.Click += new System.EventHandler(this.priClick);
            this.pbPozadina.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DviziGluvce);
            // 
            // timerDviziProtivnik
            // 
            this.timerDviziProtivnik.Enabled = true;
            this.timerDviziProtivnik.Interval = 10;
            this.timerDviziProtivnik.Tick += new System.EventHandler(this.PridviziProt);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.DodadiNovProtivnik);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(273, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "100 %";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbPozadina);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPozadina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPozadina;
        private System.Windows.Forms.Timer timerDviziProtivnik;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

