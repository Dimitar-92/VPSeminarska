namespace Igra_za_proektnu
{
    partial class OsnovnaForma
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
            this.tlSvojstva = new System.Windows.Forms.TableLayoutPanel();
            this.pbSound = new System.Windows.Forms.PictureBox();
            nacinIgra = new Igra_za_proektnu.NacinIgra();
            rekordi = new Igra_za_proektnu.Rekordi();
            osnovenPogled = new Igra_za_proektnu.OsnovenPogled();
            izberiSvojstva = new Igra_za_proektnu.IzberiSvojstva();
            glavenPogled = new Igra_za_proektnu.GlavenPogled();
            this.tlSvojstva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).BeginInit();
            this.SuspendLayout();
            // 
            // tlSvojstva
            // 
            this.tlSvojstva.BackColor = System.Drawing.Color.Transparent;
            this.tlSvojstva.ColumnCount = 1;
            this.tlSvojstva.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlSvojstva.Controls.Add(this.pbSound, 0, 0);
            this.tlSvojstva.Controls.Add(nacinIgra, 0, 1);
            this.tlSvojstva.Controls.Add(rekordi, 0, 1);
            this.tlSvojstva.Controls.Add(osnovenPogled, 0, 1);
            this.tlSvojstva.Controls.Add(izberiSvojstva, 0, 1);
            this.tlSvojstva.Controls.Add(glavenPogled, 0, 1);
            this.tlSvojstva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlSvojstva.Location = new System.Drawing.Point(0, 0);
            this.tlSvojstva.Margin = new System.Windows.Forms.Padding(5);
            this.tlSvojstva.Name = "tlSvojstva";
            this.tlSvojstva.RowCount = 2;
            this.tlSvojstva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.560723F));
            this.tlSvojstva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.43928F));
            this.tlSvojstva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlSvojstva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlSvojstva.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlSvojstva.Size = new System.Drawing.Size(984, 561);
            this.tlSvojstva.TabIndex = 2;
            // 
            // pbSound
            // 
            this.pbSound.Location = new System.Drawing.Point(3, 3);
            this.pbSound.Name = "pbSound";
            this.pbSound.Size = new System.Drawing.Size(54, 30);
            this.pbSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSound.TabIndex = 0;
            this.pbSound.TabStop = false;
            // 
            // nacinIgra
            // 
            nacinIgra.Dock = System.Windows.Forms.DockStyle.Fill;
            nacinIgra.Location = new System.Drawing.Point(3, 523);
            nacinIgra.Name = "nacinIgra";
            nacinIgra.Size = new System.Drawing.Size(978, 14);
            nacinIgra.TabIndex = 1;
            // 
            // rekordi
            // 
            rekordi.BackColor = System.Drawing.Color.Transparent;
            rekordi.Dock = System.Windows.Forms.DockStyle.Fill;
            rekordi.Location = new System.Drawing.Point(3, 543);
            rekordi.Name = "rekordi";
            rekordi.Size = new System.Drawing.Size(978, 15);
            rekordi.TabIndex = 1;
            // 
            // osnovenPogled
            // 
            osnovenPogled.BackColor = System.Drawing.Color.Transparent;
            osnovenPogled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            osnovenPogled.Dock = System.Windows.Forms.DockStyle.Fill;
            osnovenPogled.Location = new System.Drawing.Point(3, 50);
            osnovenPogled.Name = "osnovenPogled";
            osnovenPogled.Size = new System.Drawing.Size(978, 447);
            osnovenPogled.TabIndex = 1;
            // 
            // izberiSvojstva
            // 
            izberiSvojstva.BackColor = System.Drawing.Color.Transparent;
            izberiSvojstva.Dock = System.Windows.Forms.DockStyle.Fill;
            izberiSvojstva.Location = new System.Drawing.Point(3, 503);
            izberiSvojstva.Name = "izberiSvojstva";
            izberiSvojstva.Size = new System.Drawing.Size(978, 14);
            izberiSvojstva.TabIndex = 0;
            // 
            // glavenPogled
            // 
            glavenPogled.BackColor = System.Drawing.Color.Transparent;
            glavenPogled.Dock = System.Windows.Forms.DockStyle.Fill;
            glavenPogled.Location = new System.Drawing.Point(3, 503);
            glavenPogled.Name = "glavenPogled";
            glavenPogled.Size = new System.Drawing.Size(978, 14);
            glavenPogled.TabIndex = 0;
            // 
            // OsnovnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Igra_za_proektnu.Properties.Resources.townscape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tlSvojstva);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "OsnovnaForma";
            this.Text = "Igra";
            this.tlSvojstva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlSvojstva;
        private System.Windows.Forms.PictureBox pbSound;
        public static OsnovenPogled osnovenPogled;
        public static NacinIgra nacinIgra;
        public static IzberiSvojstva izberiSvojstva;
        public static Rekordi rekordi;
        public static GlavenPogled glavenPogled;


    }
}

