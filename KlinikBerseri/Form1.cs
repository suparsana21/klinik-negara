using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            Form1 mainForm = new Form1();
            mainForm.CenterToScreen();

            FormDokter frmDokter = new FormDokter();
            frmDokter.TopLevel = false;
            frmDokter.MdiParent = mainForm;
            mainForm.mainPanel.Controls.Add(frmDokter);
            frmDokter.Show();

            //acaha acaha nehi
        }

        private void btnFormDokter_Click(object sender, EventArgs e)
        {
            
            FormDokter frmDokter = new FormDokter();
            frmDokter.TopLevel = false;
            mainPanel.Controls.Add(frmDokter);
            frmDokter.Show();
        }
    }
}
