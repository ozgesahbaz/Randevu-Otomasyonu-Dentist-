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
    public partial class frmCustomer : Form
    {
        public List<Doctor> DoctorList;
        public List<Customer> CustomerList;

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool isValid = true;

            if (cmbDoctors.SelectedIndex == -1)
            {
                MessageBox.Show("Doktor seçmediniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Hasta adı boş geçilemez.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtCustomerPhone.Text) || txtCustomerPhone.MaskFull == false)
            {
                MessageBox.Show("Hasta telefonu boş geçilemez.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            foreach (Customer customer in CustomerList)
            {
                if (customer.TcNo == txtCustomerTcNo.Text)
                {
                    MessageBox.Show("Bu hasta zaten sistemde kayıtlı.", "Hasta Zaten Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cmbDoctors.Items.Clear();

            foreach (Doctor doctor in DoctorList)
            {
                cmbDoctors.Items.Add($"{doctor.FullName}-{doctor.TcNo}");
            }
        }
    }
}
