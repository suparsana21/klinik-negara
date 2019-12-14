using KlinikBerseri.Pages;
using KlinikBerseri.Pages.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KlinikBerseri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //acha acha
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(frm);
            frm.Show();

            //acaha acaha nehi
        }

        private void btnFormDokter_Click(object sender, EventArgs e)
        {
            
            FormDokter frmDokter = new FormDokter();
            frmDokter.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(frmDokter);
            frmDokter.Show();
        }

        private void btnFormPasien_Click(object sender, EventArgs e)
        {
            ListPatient frm = new ListPatient();
            frm.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard();
            frm.TopLevel = false;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(frm);
            frm.Show();
        }
    }
}
