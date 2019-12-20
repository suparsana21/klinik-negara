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
            dgvListAction.DataMember = "doctors";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModalAction modalAction = new ModalAction(this);
            modalAction.ShowDialog();
        }
    }
}
