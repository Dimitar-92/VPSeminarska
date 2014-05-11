namespace Igra_za_proektnu
{
    partial class NovRekord
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
            this.tbIme = new System.Windows.Forms.TextBox();
            this.btnVnesi = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(6, 19);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(175, 20);
            this.tbIme.TabIndex = 0;
            // 
            // btnVnesi
            // 
            this.btnVnesi.BackColor = System.Drawing.Color.Transparent;
            this.btnVnesi.BackgroundImage = global::Igra_za_proektnu.Properties.Resources.puss;
            this.btnVnesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVnesi.Location = new System.Drawing.Point(12, 73);
            this.btnVnesi.Name = "btnVnesi";
            this.btnVnesi.Size = new System.Drawing.Size(135, 56);
            this.btnVnesi.TabIndex = 2;
            this.btnVnesi.Text = "Внеси";
            this.btnVnesi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVnesi.UseVisualStyleBackColor = false;
            this.btnVnesi.Click += new System.EventHandler(this.btnVnesi_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.BackColor = System.Drawing.Color.Transparent;
            this.btnOtkazi.BackgroundImage = global::Igra_za_proektnu.Properties.Resources.puss;
            this.btnOtkazi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOtkazi.Location = new System.Drawing.Point(173, 73);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(135, 56);
            this.btnOtkazi.TabIndex = 3;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOtkazi.UseVisualStyleBackColor = false;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.tbIme);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Внесете го Вашето име (без празно место)";
            // 
            // NovRekord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Igra_za_proektnu.Properties.Resources.townscape;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 141);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.btnVnesi);
            this.Name = "NovRekord";
            this.Text = "Нов рекорд";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnVnesi;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}