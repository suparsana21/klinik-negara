using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlinikBerseri.Pages.Patient;
using KlinikBerseri.Pages.Examination;
using KlinikBerseri.Pages.Action;

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

            FormAction formAction = new FormAction();
            formAction.TopLevel = false;
            formAction.MdiParent = mainForm;
            mainForm.mainPanel.Controls.Add(formAction);
            formAction.Show();

            FormPatient formPatient = new FormPatient();
            formPatient.TopLevel = false;
            formPatient.MdiParent = mainForm;
            mainForm.mainPanel.Controls.Add(formPatient);
            formPatient.Show();

            FormExamination formExamination = new FormExamination();
            formExamination.TopLevel = false;
            formExamination.MdiParent = mainForm;
            mainForm.mainPanel.Controls.Add(formExamination);
            formPatient.Show();

        }

        private void btnFormDokter_Click(object sender, EventArgs e)
        {
            
            FormDokter frmDokter = new FormDokter();
            frmDokter.TopLevel = false;
            mainPanel.Controls.Add(frmDokter);
            frmDokter.Show();
        }

        private void btnFormPasien_Click(object sender, EventArgs e)
        {
            FormPatient formPatient = new FormPatient();
            formPatient.TopLevel = false;
            mainPanel.Controls.Add(formPatient);
            formPatient.Show();
        }

        private void btnDataPemeriksaan_Click(object sender, EventArgs e)
        {
            FormExamination formExamination = new FormExamination();
            formExamination.TopLevel = false;
            mainPanel.Controls.Add(formExamination);
            formExamination.Show();
        }

        private void btnFormAction_Click(object sender, EventArgs e)
        {
            FormAction formAction = new FormAction();
            formAction.TopLevel = false;
            mainPanel.Controls.Add(formAction);
            formAction.Show();
        }
    }
}
