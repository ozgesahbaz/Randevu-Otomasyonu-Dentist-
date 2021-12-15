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
    public partial class frmCustomerEdit : Form
    {
        public frmCustomerEdit()
        {
            InitializeComponent();
        }

        public Customer CustomerData;
        public List<Doctor> DoctorList;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCustomerEdit_Load(object sender, EventArgs e)
        {
            cmbDoctors.Items.Clear();

            foreach (Doctor doctor in DoctorList)
            {
                cmbDoctors.Items.Add($"{doctor.FullName}-{doctor.TcNo}");

                if (doctor.TcNo == CustomerData.DoctorTcNo)
                {
                    cmbDoctors.SelectedIndex = DoctorList.IndexOf(doctor);
                    //cmbDoctors.SelectedIndex = cmbDoctors.Items.Count - 1;
                }
            }

            txtCustomerName.Text = CustomerData.FullName;
            txtCustomerEmail.Text = CustomerData.Email;
            txtCustomerPhone.Text = CustomerData.Phone;
            txtCustomerTcNo.Text = CustomerData.TcNo;
            txtCustomerNote.Text = CustomerData.Note;
            dtpCustomerBirthDate.Value = CustomerData.BirthDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // validation lar.

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
