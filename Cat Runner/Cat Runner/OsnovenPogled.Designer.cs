namespace Cat_Runner
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRekordi
            // 
            this.btnRekordi.BackgroundImage = global::Cat_Runner.Properties.Resources.puss;
            this.btnRekordi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRekordi.Location = new System.Drawing.Point(583, 36);
            this.btnRekordi.Name = "btnRekordi";
            this.btnRekordi.Size = new System.Drawing.Size(283, 157);
            this.btnRekordi.TabIndex = 4;
            this.btnRekordi.Text = "Рекорди";
            this.btnRekordi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRekordi.UseVisualStyleBackColor = true;
            this.btnRekordi.Click += new System.EventHandler(this.btnRekordi_Click);
            // 
            // btnPocni
            // 
            this.btnPocni.BackgroundImage = global::Cat_Runner.Properties.Resources.puss;
            this.btnPocni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPocni.Location = new System.Drawing.Point(259, 36);
            this.btnPocni.Name = "btnPocni";
            this.btnPocni.Size = new System.Drawing.Size(283, 157);
            this.btnPocni.TabIndex = 3;
            this.btnPocni.Text = "Нова игра";
            this.btnPocni.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPocni.UseVisualStyleBackColor = true;
            this.btnPocni.Click += new System.EventHandler(this.btnPocni_Click);
            // 
            // btnNacinIgra
            // 
            this.btnNacinIgra.BackgroundImage = global::Cat_Runner.Properties.Resources.puss;
            this.btnNacinIgra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNacinIgra.Location = new System.Drawing.Point(259, 219);
            this.btnNacinIgra.Name = "btnNacinIgra";
            this.btnNacinIgra.Size = new System.Drawing.Size(283, 157);
            this.btnNacinIgra.TabIndex = 6;
            this.btnNacinIgra.Text = "Начин на играње";
            this.btnNacinIgra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNacinIgra.UseVisualStyleBackColor = true;
            this.btnNacinIgra.Click += new System.EventHandler(this.btnNacinIgra_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.BackgroundImage = global::Cat_Runner.Properties.Resources.puss;
            this.btnZatvori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZatvori.Location = new System.Drawing.Point(583, 219);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(283, 157);
            this.btnZatvori.TabIndex = 7;
            this.btnZatvori.Text = "Затвори";
            this.btnZatvori.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // OsnovenPogled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnNacinIgra);
            this.Controls.Add(this.btnRekordi);
            this.Controls.Add(this.btnPocni);
            this.Name = "OsnovenPogled";
            this.Size = new System.Drawing.Size(922, 456);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRekordi;
        private System.Windows.Forms.Button btnPocni;
        private System.Windows.Forms.Button btnNacinIgra;
        private System.Windows.Forms.Button btnZatvori;
    }
}
