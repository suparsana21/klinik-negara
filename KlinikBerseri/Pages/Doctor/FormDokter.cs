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
        //DoctorController doctorController = new DoctorController();

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
            ModalDoctor modalDoctor = new ModalDoctor();
            modalDoctor.ShowDialog();

        }

        private void dgvListDokter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void initData()
        {
           
        }
    }
}
