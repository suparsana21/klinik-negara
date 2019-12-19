using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikBerseri.Pages.Doctor
{

    public partial class ModalDoctor : Form
    {
        FormDokter formDokter;
        DoctorDAO doctorDAO = new DoctorDAO();
        public ModalDoctor(FormDokter parentForm)
        {
            formDokter = parentForm;
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            DoctorModel doctor = new DoctorModel();

            doctor.Name = edtNama.Text;
            doctor.Address = edtAddress.Text;
            doctor.Phone = edtPhone.Text;
            doctor.Specialist = cmbSpecialist.Text;
            bool insert = doctorDAO.insertData(doctor);

            if (insert) 
            {
                formDokter.getAllData();
                Dispose();
            }
        }

        private void ModalDoctor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
