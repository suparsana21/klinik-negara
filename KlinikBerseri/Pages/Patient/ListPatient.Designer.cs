namespace KlinikBerseri.Pages.Patient
{
    partial class ListPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFormPatient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListDokter = new System.Windows.Forms.DataGridView();
            this.idx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDokter)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 67);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFormPatient);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(713, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 67);
            this.panel2.TabIndex = 1;
            // 
            // btnFormPatient
            // 
            this.btnFormPatient.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFormPatient.FlatAppearance.BorderSize = 0;
            this.btnFormPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormPatient.Font = new System.Drawing.Font("Tw Cen MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFormPatient.Location = new System.Drawing.Point(73, 15);
            this.btnFormPatient.Name = "btnFormPatient";
            this.btnFormPatient.Size = new System.Drawing.Size(126, 39);
            this.btnFormPatient.TabIndex = 0;
            this.btnFormPatient.Text = "Tambah Pasien";
            this.btnFormPatient.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pasien";
            // 
            // dgvListDokter
            // 
            this.dgvListDokter.AllowUserToDeleteRows = false;
            this.dgvListDokter.AllowUserToResizeColumns = false;
            this.dgvListDokter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListDokter.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListDokter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListDokter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListDokter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListDokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDokter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idx,
            this.name,
            this.address,
            this.phone,
            this.specialist});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListDokter.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListDokter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListDokter.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListDokter.Location = new System.Drawing.Point(0, 67);
            this.dgvListDokter.Name = "dgvListDokter";
            this.dgvListDokter.ReadOnly = true;
            this.dgvListDokter.Size = new System.Drawing.Size(937, 561);
            this.dgvListDokter.TabIndex = 2;
            this.dgvListDokter.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListDokter_CellContentClick);
            // 
            // idx
            // 
            this.idx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idx.HeaderText = "No";
            this.idx.Name = "idx";
            this.idx.ReadOnly = true;
            this.idx.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idx.Width = 55;
            // 
            // name
            // 
            this.name.HeaderText = "Nama";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Alamat";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "No Telp";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // specialist
            // 
            this.specialist.HeaderText = "Spesialis";
            this.specialist.Name = "specialist";
            this.specialist.ReadOnly = true;
            // 
            // ListPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 628);
            this.Controls.Add(this.dgvListDokter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "ListPatient";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListPatient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDokter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFormPatient;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvListDokter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idx;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialist;

    }
}