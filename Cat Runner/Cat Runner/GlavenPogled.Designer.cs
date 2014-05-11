namespace Cat_Runner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavenPogled));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelIgra = new System.Windows.Forms.Panel();
            this.pnlSvojstva = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNazad = new System.Windows.Forms.Button();
            this.progressEnergy1 = new Cat_Runner.ProgressEnergy();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlSvojstva.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelIgra, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlSvojstva, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.14893F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.85106F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(979, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panelIgra
            // 
            this.panelIgra.BackColor = System.Drawing.Color.Transparent;
            this.panelIgra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIgra.Location = new System.Drawing.Point(3, 3);
            this.panelIgra.Name = "panelIgra";
            this.panelIgra.Size = new System.Drawing.Size(973, 413);
            this.panelIgra.TabIndex = 1;
            // 
            // pnlSvojstva
            // 
            this.pnlSvojstva.BackColor = System.Drawing.Color.Transparent;
            this.pnlSvojstva.Controls.Add(this.progressEnergy1);
            this.pnlSvojstva.Controls.Add(this.label3);
            this.pnlSvojstva.Controls.Add(this.label2);
            this.pnlSvojstva.Controls.Add(this.label1);
            this.pnlSvojstva.Controls.Add(this.btnNazad);
            this.pnlSvojstva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSvojstva.Location = new System.Drawing.Point(3, 422);
            this.pnlSvojstva.Name = "pnlSvojstva";
            this.pnlSvojstva.Size = new System.Drawing.Size(973, 46);
            this.pnlSvojstva.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(817, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(748, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поени :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(203, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Енергија :";
            // 
            // btnNazad
            // 
            this.btnNazad.BackgroundImage = global::Cat_Runner.Properties.Resources.puss_in_boots;
            this.btnNazad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNazad.Location = new System.Drawing.Point(14, 3);
            this.btnNazad.Name = "btnNazad";
            this.btnNazad.Size = new System.Drawing.Size(84, 40);
            this.btnNazad.TabIndex = 0;
            this.btnNazad.Text = "Крај";
            this.btnNazad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNazad.UseVisualStyleBackColor = true;
            this.btnNazad.Click += new System.EventHandler(this.btnNazad_Click);
            // 
            // progressEnergy1
            // 
            this.progressEnergy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressEnergy1.BackgroundImage")));
            this.progressEnergy1.Location = new System.Drawing.Point(293, 3);
            this.progressEnergy1.Name = "progressEnergy1";
            this.progressEnergy1.Size = new System.Drawing.Size(286, 40);
            this.progressEnergy1.TabIndex = 0;
            this.progressEnergy1.Vrednost = 0;
            // 
            // GlavenPogled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GlavenPogled";
            this.Size = new System.Drawing.Size(979, 471);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlSvojstva.ResumeLayout(false);
            this.pnlSvojstva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlSvojstva;
        private System.Windows.Forms.Button btnNazad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelIgra;
        private System.Windows.Forms.Label label3;
        private ProgressEnergy progressEnergy1;

    }
}
