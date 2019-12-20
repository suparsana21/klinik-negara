using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikBerseri.Pages.Patient
{
    public partial class ModalPatient : Form
    {
        FormPatient formPatient;
        PatientDAO patientDAO = new PatientDAO();
        public ModalPatient(FormPatient parentPatient)
        {
            formPatient = parentPatient;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PatientModel patient = new PatientModel();

            patient.Name = edtName.Text;
            patient.Gendre = cmbGender.Text;
            patient.Address = edtAddress.Text;
            patient.Phone = edtPhone.Text;
            bool insert = patientDAO.insertData(patient);

            if (insert)
            {
                formPatient.getAllData();
                Dispose();
            }
        }

        public void ModalPatient_Load(object sender, EventArgs e)
        {

        }

        internal void ModalPatient_Load(FormPatient parent, string v)
        {
           
        }
    }
}
