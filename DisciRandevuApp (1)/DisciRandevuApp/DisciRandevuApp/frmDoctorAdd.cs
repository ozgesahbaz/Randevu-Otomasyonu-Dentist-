using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisciRandevuApp
{
    public partial class frmDoctorAdd : Form
    {
        public frmDoctorAdd()
        {
            InitializeComponent();
        }

        public bool IsEdit = false;
        public Doctor DoctorData;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validations..

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDoctorAdd_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                Text = "Doktor Düzenle";
                btnAdd.Text = "Kaydet";

                txtDoctorName.Text = DoctorData.FullName;
                txtDoctorEmail.Text = DoctorData.Email;
                txtDoctorPhone.Text = DoctorData.Phone;
                txtDoctorField.Text = DoctorData.Field;
                txtDoctorTcNo.Text = DoctorData.TcNo;
            }
            else
            {
                Text = "Yeni Doktor Ekle";
                btnAdd.Text = "Ekle";
            }
        }
    }
}
