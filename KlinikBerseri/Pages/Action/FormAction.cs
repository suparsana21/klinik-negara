using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlinikBerseri.Pages.Action
{
    public partial class FormAction : Form
    {
        ActionDAO actionDAO = new ActionDAO();
        public FormAction()
        {
            InitializeComponent();
        }

        private void FormAction_Load(object sender, EventArgs e)
        {
            getAllData();
        }

        public void getAllData()
        {
            DataSet data = actionDAO.getData();
            dgvListAction.DataSource = data;
            dgvListAction.DataMember = "actions";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModalAction modalAction = new ModalAction(this);
            modalAction.ShowDialog();
        }

        private void dgvListAction_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();

                int currentMouseOverRow = dgvListAction.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    menu.MenuItems.Add(new MenuItem("Hapus", deleteData));
                    //menu.MenuItems.Add(new MenuItem("Edit", editData));
                    dgvListAction.Rows[currentMouseOverRow].Selected = true;
                }
                menu.Show(dgvListAction, new Point(e.X, e.Y));
            }
        }

        private void deleteData(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvListAction.SelectedRows[0];
            var confirm = MessageBox.Show("Apakah anda yakin akan menghapus data pasien " + dgvRow.Cells["name"].Value.ToString() + " ? ",
                "Konfirmasi",
               MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                bool deleted = actionDAO.deleteData(dgvRow.Cells["id"].Value.ToString());
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

        private void dgvListAction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListAction_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
