namespace Igra_za_proektnu
{
    partial class IzberiSvojstva
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoja = new System.Windows.Forms.ComboBox();
            this.lblBoja = new System.Windows.Forms.Label();
            this.lblIzborLik = new System.Windows.Forms.Label();
            this.imgLstLikovi = new System.Windows.Forms.ImageList(this.components);
            this.pbLikovi = new System.Windows.Forms.PictureBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.btnIzberi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioGluvce = new System.Windows.Forms.RadioButton();
            this.radioTastatura = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbLikovi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izberete svojstva:";
            // 
            // comboBoja
            // 
            this.comboBoja.FormattingEnabled = true;
            this.comboBoja.Location = new System.Drawing.Point(139, 70);
            this.comboBoja.Name = "comboBoja";
            this.comboBoja.Size = new System.Drawing.Size(121, 21);
            this.comboBoja.TabIndex = 1;
            // 
            // lblBoja
            // 
            this.lblBoja.AutoSize = true;
            this.lblBoja.Location = new System.Drawing.Point(48, 70);
            this.lblBoja.Name = "lblBoja";
            this.lblBoja.Size = new System.Drawing.Size(31, 13);
            this.lblBoja.TabIndex = 2;
            this.lblBoja.Text = "Boja:";
            // 
            // lblIzborLik
            // 
            this.lblIzborLik.AutoSize = true;
            this.lblIzborLik.Location = new System.Drawing.Point(48, 118);
            this.lblIzborLik.Name = "lblIzborLik";
            this.lblIzborLik.Size = new System.Drawing.Size(61, 13);
            this.lblIzborLik.TabIndex = 3;
            this.lblIzborLik.Text = "Izberete lik:";
            // 
            // imgLstLikovi
            // 
            this.imgLstLikovi.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLstLikovi.ImageSize = new System.Drawing.Size(16, 16);
            this.imgLstLikovi.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbLikovi
            // 
            this.pbLikovi.BackColor = System.Drawing.Color.Transparent;
            this.pbLikovi.Location = new System.Drawing.Point(139, 118);
            this.pbLikovi.Name = "pbLikovi";
            this.pbLikovi.Size = new System.Drawing.Size(121, 50);
            this.pbLikovi.TabIndex = 4;
            this.pbLikovi.TabStop = false;
            // 
            // btnNazad
            // 
            this.btnNazad.Location = new System.Drawing.Point(185, 263);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(139, 31);
            this.btnNazad.TabIndex = 5;
            this.btnNazad.Text = "Nazad";
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // btnIzberi
            // 
            this.btnIzberi.Location = new System.Drawing.Point(341, 263);
            this.btnIzberi.Name = "btnIzberi";
            this.btnIzberi.Size = new System.Drawing.Size(139, 31);
            this.btnIzberi.TabIndex = 6;
            this.btnIzberi.Text = "Izberi";
            this.btnIzberi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioTastatura);
            this.groupBox1.Controls.Add(this.radioGluvce);
            this.groupBox1.Location = new System.Drawing.Point(51, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 71);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nacin na kontrola";
            // 
            // radioGluvce
            // 
            this.radioGluvce.AutoSize = true;
            this.radioGluvce.Location = new System.Drawing.Point(6, 19);
            this.radioGluvce.Name = "radioGluvce";
            this.radioGluvce.Size = new System.Drawing.Size(59, 17);
            this.radioGluvce.TabIndex = 0;
            this.radioGluvce.TabStop = true;
            this.radioGluvce.Text = "Gluvce";
            this.radioGluvce.UseVisualStyleBackColor = true;
            this.radioGluvce.CheckedChanged += new System.EventHandler(this.radioGluvce_CheckedChanged);
            // 
            // radioTastatura
            // 
            this.radioTastatura.AutoSize = true;
            this.radioTastatura.Location = new System.Drawing.Point(7, 43);
            this.radioTastatura.Name = "radioTastatura";
            this.radioTastatura.Size = new System.Drawing.Size(70, 17);
            this.radioTastatura.TabIndex = 1;
            this.radioTastatura.TabStop = true;
            this.radioTastatura.Text = "Tastatura";
            this.radioTastatura.UseVisualStyleBackColor = true;
            this.radioTastatura.CheckedChanged += new System.EventHandler(this.radioGluvce_CheckedChanged);
            // 
            // IzberiSvojstva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzberi);
            this.Controls.Add(this.btnNazad);
            this.Controls.Add(this.pbLikovi);
            this.Controls.Add(this.lblIzborLik);
            this.Controls.Add(this.lblBoja);
            this.Controls.Add(this.comboBoja);
            this.Controls.Add(this.label1);
            this.Name = "IzberiSvojstva";
            this.Size = new System.Drawing.Size(505, 314);
            ((System.ComponentModel.ISupportInitialize)(this.pbLikovi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoja;
        private System.Windows.Forms.Label lblBoja;
        private System.Windows.Forms.Label lblIzborLik;
        private System.Windows.Forms.ImageList imgLstLikovi;
        private System.Windows.Forms.PictureBox pbLikovi;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Button btnIzberi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioTastatura;
        private System.Windows.Forms.RadioButton radioGluvce;
    }
}
