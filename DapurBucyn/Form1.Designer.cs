namespace DapurBucyn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nASIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daftarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bahanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jENISToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pEMBELIANToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pENGGUNAANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SaddleBrown;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nASIToolStripMenuItem,
            this.bahanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(724, 38);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // nASIToolStripMenuItem
            // 
            this.nASIToolStripMenuItem.Checked = true;
            this.nASIToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nASIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daftarToolStripMenuItem,
            this.pembelianToolStripMenuItem});
            this.nASIToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nASIToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.nASIToolStripMenuItem.Name = "nASIToolStripMenuItem";
            this.nASIToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nASIToolStripMenuItem.Size = new System.Drawing.Size(51, 30);
            this.nASIToolStripMenuItem.Text = "NASI";
            this.nASIToolStripMenuItem.Click += new System.EventHandler(this.nASIToolStripMenuItem_Click);
            // 
            // daftarToolStripMenuItem
            // 
            this.daftarToolStripMenuItem.Name = "daftarToolStripMenuItem";
            this.daftarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.daftarToolStripMenuItem.Text = "Daftar";
            this.daftarToolStripMenuItem.Click += new System.EventHandler(this.daftarToolStripMenuItem_Click);
            // 
            // pembelianToolStripMenuItem
            // 
            this.pembelianToolStripMenuItem.Name = "pembelianToolStripMenuItem";
            this.pembelianToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pembelianToolStripMenuItem.Text = "Penjualan";
            this.pembelianToolStripMenuItem.Click += new System.EventHandler(this.pembelianToolStripMenuItem_Click);
            // 
            // bahanToolStripMenuItem
            // 
            this.bahanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jENISToolStripMenuItem1,
            this.pEMBELIANToolStripMenuItem1,
            this.pENGGUNAANToolStripMenuItem});
            this.bahanToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bahanToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.bahanToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.bahanToolStripMenuItem.Name = "bahanToolStripMenuItem";
            this.bahanToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bahanToolStripMenuItem.Size = new System.Drawing.Size(67, 30);
            this.bahanToolStripMenuItem.Text = "BAHAN";
            this.bahanToolStripMenuItem.Click += new System.EventHandler(this.bahanToolStripMenuItem_Click);
            // 
            // jENISToolStripMenuItem1
            // 
            this.jENISToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkOrange;
            this.jENISToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.jENISToolStripMenuItem1.Name = "jENISToolStripMenuItem1";
            this.jENISToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.jENISToolStripMenuItem1.Text = "JENIS";
            this.jENISToolStripMenuItem1.Click += new System.EventHandler(this.jENISToolStripMenuItem1_Click);
            // 
            // pEMBELIANToolStripMenuItem1
            // 
            this.pEMBELIANToolStripMenuItem1.ForeColor = System.Drawing.Color.DarkOrange;
            this.pEMBELIANToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pEMBELIANToolStripMenuItem1.Name = "pEMBELIANToolStripMenuItem1";
            this.pEMBELIANToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pEMBELIANToolStripMenuItem1.Text = "PEMBELIAN";
            this.pEMBELIANToolStripMenuItem1.Click += new System.EventHandler(this.pEMBELIANToolStripMenuItem1_Click);
            // 
            // pENGGUNAANToolStripMenuItem
            // 
            this.pENGGUNAANToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.pENGGUNAANToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pENGGUNAANToolStripMenuItem.Name = "pENGGUNAANToolStripMenuItem";
            this.pENGGUNAANToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pENGGUNAANToolStripMenuItem.Text = "PENGGUNAAN";
            this.pENGGUNAANToolStripMenuItem.Click += new System.EventHandler(this.pENGGUNAANToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(684, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(536, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "DAPUR BUCYN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(724, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bahanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jENISToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pEMBELIANToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pENGGUNAANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nASIToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem daftarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembelianToolStripMenuItem;
    }
}

