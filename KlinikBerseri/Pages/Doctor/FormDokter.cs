using KlinikBerseri.Pages.Doctor;
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
    public partial class FormDokter : Form
    {
        DoctorDAO doctorDAO = new DoctorDAO();

        public FormDokter()
        {
            InitializeComponent();
        }

        private void FormDokter_Load(object sender, EventArgs e)
        {
            getAllData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModalDoctor modalDoctor = new ModalDoctor(this);
            modalDoctor.ShowDialog();

        }

        public void getAllData()
        {
            DataSet data = doctorDAO.getData();
            dgvListDokter.DataSource = data;
            dgvListDokter.DataMember = "doctors";
        }

        private void dgvListDokter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();

                int currentMouseOverRow = dgvListDokter.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    menu.MenuItems.Add(new MenuItem("Hapus", deleteData));
                    menu.MenuItems.Add(new MenuItem("Edit", editData));
                    dgvListDokter.Rows[currentMouseOverRow].Selected = true;
                }
                menu.Show(dgvListDokter, new Point(e.X, e.Y));
            }
        }

        private void editData(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvListDokter.SelectedRows[0];
            ModalDoctor modalDoctor = new ModalDoctor(this);
            modalDoctor.ShowDialog();
        }

        private void deleteData(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvListDokter.SelectedRows[0];
            var confirm = MessageBox.Show("Apakah anda yakin akan menghapus data dokter " + dgvRow.Cells["name"].Value.ToString() + " ? ",
                "Konfirmasi",
               MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                bool deleted = doctorDAO.deleteData(dgvRow.Cells["id"].Value.ToString());
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
    }
}
