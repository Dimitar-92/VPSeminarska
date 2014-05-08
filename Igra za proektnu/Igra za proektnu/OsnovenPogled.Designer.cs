namespace Igra_za_proektnu
{
    partial class OsnovenPogled
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
            this.btnRekordi = new System.Windows.Forms.Button();
            this.btnPocni = new System.Windows.Forms.Button();
            this.btnNacinIgra = new System.Windows.Forms.Button();
            this.btnIzberiSvojstva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRekordi
            // 
            this.btnRekordi.Location = new System.Drawing.Point(305, 276);
            this.btnRekordi.Name = "btnRekordi";
            this.btnRekordi.Size = new System.Drawing.Size(200, 30);
            this.btnRekordi.TabIndex = 4;
            this.btnRekordi.Text = "Rekordi";
            this.btnRekordi.UseVisualStyleBackColor = true;
            this.btnRekordi.Click += new System.EventHandler(this.btnRekordi_Click);
            // 
            // btnPocni
            // 
            this.btnPocni.Location = new System.Drawing.Point(305, 150);
            this.btnPocni.Name = "btnPocni";
            this.btnPocni.Size = new System.Drawing.Size(200, 30);
            this.btnPocni.TabIndex = 3;
            this.btnPocni.Text = "Pocetok";
            this.btnPocni.UseVisualStyleBackColor = true;
            this.btnPocni.Click += new System.EventHandler(this.btnPocni_Click);
            // 
            // btnNacinIgra
            // 
            this.btnNacinIgra.Location = new System.Drawing.Point(305, 240);
            this.btnNacinIgra.Name = "btnNacinIgra";
            this.btnNacinIgra.Size = new System.Drawing.Size(200, 30);
            this.btnNacinIgra.TabIndex = 6;
            this.btnNacinIgra.Text = "Nacin na igranje";
            this.btnNacinIgra.UseVisualStyleBackColor = true;
            this.btnNacinIgra.Click += new System.EventHandler(this.btnNacinIgra_Click);
            // 
            // btnIzberiSvojstva
            // 
            this.btnIzberiSvojstva.Location = new System.Drawing.Point(305, 186);
            this.btnIzberiSvojstva.Name = "btnIzberiSvojstva";
            this.btnIzberiSvojstva.Size = new System.Drawing.Size(200, 30);
            this.btnIzberiSvojstva.TabIndex = 7;
            this.btnIzberiSvojstva.Text = "Svojstva";
            this.btnIzberiSvojstva.UseVisualStyleBackColor = true;
            this.btnIzberiSvojstva.Click += new System.EventHandler(this.btnIzberiSvojstva_Click);
            // 
            // OsnovenPogled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnIzberiSvojstva);
            this.Controls.Add(this.btnNacinIgra);
            this.Controls.Add(this.btnRekordi);
            this.Controls.Add(this.btnPocni);
            this.Name = "OsnovenPogled";
            this.Size = new System.Drawing.Size(526, 324);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRekordi;
        private System.Windows.Forms.Button btnPocni;
        private System.Windows.Forms.Button btnNacinIgra;
        private System.Windows.Forms.Button btnIzberiSvojstva;
    }
}
