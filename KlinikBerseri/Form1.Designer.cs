namespace KlinikBerseri
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFormDokter = new System.Windows.Forms.Button();
            this.btnFormPasien = new System.Windows.Forms.Button();
            this.btnFormPemeriksaan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDataPemeriksaan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLaporanPemeriksaan = new System.Windows.Forms.Button();
            this.btnLaporanRiwayatPasien = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 49);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(25, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Klinik Berseri";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnLaporanRiwayatPasien);
            this.panel2.Controls.Add(this.btnLaporanPemeriksaan);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnDataPemeriksaan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnFormPemeriksaan);
            this.panel2.Controls.Add(this.btnFormPasien);
            this.panel2.Controls.Add(this.btnFormDokter);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 634);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(984, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(72, 49);
            this.panel3.TabIndex = 4;
            // 
            // btnFormDokter
            // 
            this.btnFormDokter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFormDokter.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnFormDokter.FlatAppearance.BorderSize = 0;
            this.btnFormDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormDokter.Location = new System.Drawing.Point(0, 37);
            this.btnFormDokter.Name = "btnFormDokter";
            this.btnFormDokter.Size = new System.Drawing.Size(207, 45);
            this.btnFormDokter.TabIndex = 2;
            this.btnFormDokter.Text = "Data Dokter";
            this.btnFormDokter.UseVisualStyleBackColor = false;
            this.btnFormDokter.Click += new System.EventHandler(this.btnFormDokter_Click);
            // 
            // btnFormPasien
            // 
            this.btnFormPasien.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFormPasien.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnFormPasien.FlatAppearance.BorderSize = 0;
            this.btnFormPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormPasien.Location = new System.Drawing.Point(0, 86);
            this.btnFormPasien.Name = "btnFormPasien";
            this.btnFormPasien.Size = new System.Drawing.Size(207, 45);
            this.btnFormPasien.TabIndex = 3;
            this.btnFormPasien.Text = "Data Pasien";
            this.btnFormPasien.UseVisualStyleBackColor = false;
            // 
            // btnFormPemeriksaan
            // 
            this.btnFormPemeriksaan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFormPemeriksaan.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnFormPemeriksaan.FlatAppearance.BorderSize = 0;
            this.btnFormPemeriksaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormPemeriksaan.Location = new System.Drawing.Point(3, 136);
            this.btnFormPemeriksaan.Name = "btnFormPemeriksaan";
            this.btnFormPemeriksaan.Size = new System.Drawing.Size(207, 45);
            this.btnFormPemeriksaan.TabIndex = 4;
            this.btnFormPemeriksaan.Text = "Data Pemeriksaan";
            this.btnFormPemeriksaan.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Master Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pemeriksaan";
            // 
            // btnDataPemeriksaan
            // 
            this.btnDataPemeriksaan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDataPemeriksaan.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDataPemeriksaan.FlatAppearance.BorderSize = 0;
            this.btnDataPemeriksaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataPemeriksaan.Location = new System.Drawing.Point(0, 221);
            this.btnDataPemeriksaan.Name = "btnDataPemeriksaan";
            this.btnDataPemeriksaan.Size = new System.Drawing.Size(207, 45);
            this.btnDataPemeriksaan.TabIndex = 7;
            this.btnDataPemeriksaan.Text = "Data Pemeriksaan";
            this.btnDataPemeriksaan.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Laporan";
            // 
            // btnLaporanPemeriksaan
            // 
            this.btnLaporanPemeriksaan.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLaporanPemeriksaan.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnLaporanPemeriksaan.FlatAppearance.BorderSize = 0;
            this.btnLaporanPemeriksaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporanPemeriksaan.Location = new System.Drawing.Point(0, 307);
            this.btnLaporanPemeriksaan.Name = "btnLaporanPemeriksaan";
            this.btnLaporanPemeriksaan.Size = new System.Drawing.Size(207, 45);
            this.btnLaporanPemeriksaan.TabIndex = 9;
            this.btnLaporanPemeriksaan.Text = "Laporan Pemeriksaan";
            this.btnLaporanPemeriksaan.UseVisualStyleBackColor = false;
            // 
            // btnLaporanRiwayatPasien
            // 
            this.btnLaporanRiwayatPasien.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLaporanRiwayatPasien.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnLaporanRiwayatPasien.FlatAppearance.BorderSize = 0;
            this.btnLaporanRiwayatPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporanRiwayatPasien.Location = new System.Drawing.Point(3, 356);
            this.btnLaporanRiwayatPasien.Name = "btnLaporanRiwayatPasien";
            this.btnLaporanRiwayatPasien.Size = new System.Drawing.Size(207, 45);
            this.btnLaporanRiwayatPasien.TabIndex = 10;
            this.btnLaporanRiwayatPasien.Text = "Laporan Riwayat Pasien";
            this.btnLaporanRiwayatPasien.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(207, 635);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(849, 48);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.label1.Size = new System.Drawing.Size(115, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Copyright©2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(207, 49);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(849, 586);
            this.mainPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1056, 683);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFormDokter;
        private System.Windows.Forms.Button btnFormPasien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFormPemeriksaan;
        private System.Windows.Forms.Button btnLaporanRiwayatPasien;
        private System.Windows.Forms.Button btnLaporanPemeriksaan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDataPemeriksaan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
    }
}

