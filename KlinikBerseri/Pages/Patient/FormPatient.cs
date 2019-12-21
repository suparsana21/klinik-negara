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
    public partial class FormPatient : Form
    {
        PatientDAO patientDAO = new PatientDAO();
        public FormPatient()
        {
            InitializeComponent();
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            getAllData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModalPatient modalPatient = new ModalPatient(this);
            modalPatient.ShowDialog();
        }

        public void getAllData()
        {
            DataSet data = patientDAO.getData();
            dgvListPatient.DataSource = data;
            dgvListPatient.DataMember = "patients";
        }

        private void dgvListPatient_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();

                int currentMouseOverRow = dgvListPatient.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    menu.MenuItems.Add(new MenuItem("Hapus", deleteData));
                    menu.MenuItems.Add(new MenuItem("Edit", editData));
                    dgvListPatient.Rows[currentMouseOverRow].Selected = true;
                }
                menu.Show(dgvListPatient, new Point(e.X, e.Y));
            }
        }

        private void editData(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvListPatient.SelectedRows[0];

            ModalPatient modalPatient = new ModalPatient(this);
            string v = dgvRow.Cells["id"].Value.ToString();
            modalPatient.ModalPatient_Load(this, v);
        }

        private void deleteData(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvListPatient.SelectedRows[0];
            var confirm = MessageBox.Show("Apakah anda yakin akan menghapus data pasien " + dgvRow.Cells["name"].Value.ToString() + " ? ",
                "Konfirmasi",
               MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                bool deleted = patientDAO.deleteData(dgvRow.Cells["id"].Value.ToString());
                if (deleted)
                {
                    getAllData();
                }
                else
                {
                    MessageBox.Show("Data gagal di hapus!");
                }
            }
        }

        private void dgvListPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
