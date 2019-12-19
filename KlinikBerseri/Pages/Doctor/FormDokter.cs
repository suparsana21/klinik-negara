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
    }
}
