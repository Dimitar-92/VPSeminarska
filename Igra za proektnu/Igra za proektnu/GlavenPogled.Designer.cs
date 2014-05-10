namespace Igra_za_proektnu
{
    partial class GlavenPogled
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelIgra = new System.Windows.Forms.Panel();
            this.pnlSvojstva = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picturePoints = new System.Windows.Forms.PictureBox();
            this.pictureBlood = new System.Windows.Forms.PictureBox();
            this.btnNazad = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlSvojstva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlood)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelIgra, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlSvojstva, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.14893F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.85106F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(972, 470);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelIgra
            // 
            this.panelIgra.BackColor = System.Drawing.Color.Transparent;
            this.panelIgra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIgra.Location = new System.Drawing.Point(3, 3);
            this.panelIgra.Name = "panelIgra";
            this.panelIgra.Size = new System.Drawing.Size(966, 413);
            this.panelIgra.TabIndex = 1;
            // 
            // pnlSvojstva
            // 
            this.pnlSvojstva.BackColor = System.Drawing.Color.Transparent;
            this.pnlSvojstva.Controls.Add(this.picturePoints);
            this.pnlSvojstva.Controls.Add(this.pictureBlood);
            this.pnlSvojstva.Controls.Add(this.label2);
            this.pnlSvojstva.Controls.Add(this.label1);
            this.pnlSvojstva.Controls.Add(this.btnNazad);
            this.pnlSvojstva.Location = new System.Drawing.Point(3, 422);
            this.pnlSvojstva.Name = "pnlSvojstva";
            this.pnlSvojstva.Size = new System.Drawing.Size(966, 42);
            this.pnlSvojstva.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(602, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поени";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(176, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Енергија";
            // 
            // picturePoints
            // 
            this.picturePoints.Location = new System.Drawing.Point(647, 7);
            this.picturePoints.Name = "picturePoints";
            this.picturePoints.Size = new System.Drawing.Size(100, 32);
            this.picturePoints.TabIndex = 7;
            this.picturePoints.TabStop = false;
            // 
            // pictureBlood
            // 
            this.pictureBlood.Location = new System.Drawing.Point(233, 7);
            this.pictureBlood.Name = "pictureBlood";
            this.pictureBlood.Size = new System.Drawing.Size(267, 32);
            this.pictureBlood.TabIndex = 6;
            this.pictureBlood.TabStop = false;
            // 
            // btnNazad
            // 
            this.btnNazad.BackgroundImage = global::Igra_za_proektnu.Properties.Resources.puss_in_boots;
            this.btnNazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNazad.Location = new System.Drawing.Point(3, 4);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(84, 38);
            this.btnNazad.TabIndex = 0;
            this.btnNazad.Text = "Крај";
            this.btnNazad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // GlavenPogled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GlavenPogled";
            this.Size = new System.Drawing.Size(753, 486);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlSvojstva.ResumeLayout(false);
            this.pnlSvojstva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBlood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlSvojstva;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelIgra;
        private System.Windows.Forms.PictureBox pictureBlood;
        private System.Windows.Forms.PictureBox picturePoints;

    }
}
