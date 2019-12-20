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
    public partial class ModalAction : Form
    {
        FormAction formAction;
        ActionDAO actionDAO = new ActionDAO();
        public ModalAction(FormAction parentAction)
        {
            formAction = parentAction;
            InitializeComponent();
        }

        private void ModalAction_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ActionModel action = new ActionModel();
            
            action.Name = edtTindakan.Text;
            action.Price = int.Parse(edtHarga.Text);
            bool insert = actionDAO.insertData(action);

            if (insert)
            {
                formAction.getAllData();
                Dispose();
            }
        }
    }
}
