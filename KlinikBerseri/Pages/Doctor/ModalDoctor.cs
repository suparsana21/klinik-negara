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
        public ModalDoctor()
        {
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
            frmDokter = new FormDokter();

            DataGridViewRow row = (DataGridViewRow)frmDokter
                    .dgvListDokter.Rows[0].Clone();
                    row.Cells[0].Value = "1";
                    row.Cells[1].Value = name;
                    row.Cells[2].Value = address;
                    row.Cells[3].Value = phone;
                    row.Cells[4].Value = specialist;

            frmDokter
                .dgvListDokter
                .Rows.Add(row);

            Dispose();
        }

        private void ModalDoctor_Load(object sender, EventArgs e)
        {
        }

    }
}
