using KlinikBerseri.Controller;
//using KlinikBerseri.Controller;
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

        DoctorController doctorController = new DoctorController();

        public FormDokter()
        {
            InitializeComponent();
        }

        private void FormDokter_Load(object sender, EventArgs e)
        {
            initData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModalDoctor modalDoctor = new ModalDoctor(this);
            modalDoctor.ShowDialog();

        }

        private void dgvListDokter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void initData()
        {
            DataSet data = doctorController.getData();
            dgvListDokter.DataSource = data;            
            dgvListDokter.DataMember = "doctors";
        }

        private void dgvListDokter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                

                int currentMouseOverRow = dgvListDokter.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Hapus", deleteData));
                    dgvListDokter.Rows[currentMouseOverRow].Selected = true;

                }

                m.Show(dgvListDokter, new Point(e.X, e.Y));

            }
        }

        public void deleteData(Object sender, System.EventArgs e)
        {
            DataGridViewRow dgvRow = dgvListDokter.SelectedRows[0];
            var confrim = MessageBox.Show("Apakah anda yakin akan menghapus data dokter "+dgvRow.Cells["name"].Value.ToString() + " ? ",
                "Konfirmasi",
               MessageBoxButtons.YesNo);

            if (confrim == DialogResult.Yes)
            {
                bool deleted = doctorController.deleteData(dgvRow.Cells["id"].Value.ToString());
                if(deleted) {
                    initData();
                } else {
                    MessageBox.Show("Data gagal di hapus!");
                }
            }
        }
    }
}
