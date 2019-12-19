using KlinikBerseri.Controller;
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
        FormDokter frmDokter;

        DoctorController doctorController = new DoctorController();

        public ModalDoctor(FormDokter parentFrm)
        {
            frmDokter = parentFrm;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name,
                   address,
                   phone,
                   specialist;
            int specialistIdx;

            name    = edtNama.Text.ToString();
            address = edtAddress.Text.ToString();
            phone = edtPhone.Text.ToString();
            specialist = cmbSpecialist.SelectedItem.ToString();
            specialistIdx = cmbSpecialist.SelectedIndex;

            bool insert = doctorController.insertData(
                name,
                address,
                phone,
                specialist
                );

            if (insert)
            {
                frmDokter.initData();

                Dispose();
            }

            
        }

        private void ModalDoctor_Load(object sender, EventArgs e)
        {
        }

    }
}
