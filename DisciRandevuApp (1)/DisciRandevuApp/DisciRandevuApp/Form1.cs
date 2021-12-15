using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DisciRandevuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Doctor> Doctors = new List<Doctor>();
        List<Customer> Customers = new List<Customer>();
        string doctorsFilePath = Application.StartupPath + @"\doctors.txt";
        string customersFilePath = Application.StartupPath + @"\customers.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadTreeView();
        }

        private void btnDoctorAdd_Click(object sender, EventArgs e)
        {
            frmDoctorAdd doctorAddForm = new frmDoctorAdd();
            DialogResult result = doctorAddForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Doctors.Add(new Doctor()
                {
                    FullName = doctorAddForm.txtDoctorName.Text.ToUpper(),
                    Phone = doctorAddForm.txtDoctorPhone.Text,
                    Email = doctorAddForm.txtDoctorEmail.Text,
                    Field = doctorAddForm.txtDoctorField.Text,
                    TcNo = doctorAddForm.txtDoctorTcNo.Text,
                });

                LoadTreeView();
            }
        }


        public void LoadTreeView()
        {
            trvDoctorsCustomers.Nodes.Clear();

            foreach (Doctor doctor in Doctors)
            {
                TreeNode tnDoctor = new TreeNode(doctor.FullName);
                tnDoctor.Tag = doctor;

                foreach (Customer customer in Customers)
                {
                    if (customer.DoctorTcNo == doctor.TcNo)
                    {
                        TreeNode tnCustomer = new TreeNode(customer.FullName);
                        tnCustomer.Tag = customer;
                        tnDoctor.Nodes.Add(tnCustomer);
                    }
                }

                trvDoctorsCustomers.Nodes.Add(tnDoctor);
            }

            trvDoctorsCustomers.ExpandAll();
        }

        private void btnAppointmentAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.DoctorList = Doctors;
            frmCustomer.CustomerList = Customers;

            DialogResult result = frmCustomer.ShowDialog();

            if (result == DialogResult.OK)
            {
                string doctorTcNo = frmCustomer.cmbDoctors.Text.Split('-')[1];

                Customers.Add(new Customer()
                {
                    FullName = frmCustomer.txtCustomerName.Text.ToUpper(),
                    Phone = frmCustomer.txtCustomerPhone.Text,
                    Email = frmCustomer.txtCustomerEmail.Text,
                    BirthDate = frmCustomer.dtpCustomerBirthDate.Value,
                    Note = frmCustomer.txtCustomerNote.Text,
                    DoctorTcNo = doctorTcNo,
                    TcNo = frmCustomer.txtCustomerTcNo.Text
                });

                LoadTreeView();
            }
        }

        private void btnSaveDoctorsCustomers_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSaveAppointments_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            List<string> doctorsLines = new List<string>(Doctors.Count);
            List<string> customersLines = new List<string>(Customers.Count);

            foreach (Doctor doctor in Doctors)
            {
                doctorsLines.Add($"{doctor.FullName}|{doctor.Phone}|{doctor.Email}|{doctor.Field}|{doctor.TcNo}");
            }

            foreach (Customer customer in Customers)
            {
                customersLines.Add($"{customer.FullName}|{customer.Phone}|{customer.Email}|{customer.BirthDate.ToShortDateString()}|{customer.DoctorTcNo}|{customer.TcNo}|{customer.Note}");
            }

            File.WriteAllLines(doctorsFilePath, doctorsLines);
            File.WriteAllLines(customersFilePath, customersLines);
        }

        private void LoadData()
        {
            List<string> doctorsLines = File.ReadAllLines(doctorsFilePath).ToList();
            
            foreach (string line in doctorsLines)
            {
                string[] lineParts = line.Split('|');
                Doctor doctor = new Doctor()
                {
                    FullName = lineParts[0],
                    Phone = lineParts[1],
                    Email = lineParts[2],
                    Field = lineParts[3],
                    TcNo = lineParts[4]
                };

                Doctors.Add(doctor);
            }

            List<string> customersLines = File.ReadAllLines(customersFilePath).ToList();

            foreach (string line in customersLines)
            {
                string[] lineParts = line.Split('|');
                Customer customer = new Customer()
                {
                    FullName = lineParts[0],
                    Phone = lineParts[1],
                    Email = lineParts[2],
                    BirthDate = DateTime.Parse(lineParts[3]),   // Convert.ToDateTime(lineParts[3])
                    DoctorTcNo = lineParts[4],
                    TcNo = lineParts[5],
                    Note = lineParts[6],
                };

                Customers.Add(customer);
            }
        }

        private void trvDoctorsCustomers_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = trvDoctorsCustomers.SelectedNode;

            object obj = selectedNode.Tag;

            if (obj.GetType() == typeof(Customer))
            {
                Customer cus = (Customer)obj;
                //MessageBox.Show(cus.FullName + "\n" + cus.Phone + "\n" + cus.Email + "\n" + cus.BirthDate.ToShortDateString());
                string msg = $"Adı : {cus.FullName}\n" +
                    $"Telefonu : {cus.Phone}\n" +
                    $"E-Posta : {cus.Email}\n" +
                    $"Branş : {cus.BirthDate.ToShortDateString()}\n" +
                    $"TC No : {cus.TcNo}";
                MessageBox.Show(msg, "Hasta Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (obj.GetType() == typeof(Doctor))
            {
                Doctor dr = (Doctor)obj;
                //MessageBox.Show(dr.FullName + "\n" + dr.Phone + "\n" + dr.Email + "\n" + dr.Field);
                string msg = $"Adı : {dr.FullName}\n" +
                    $"Telefonu : {dr.Phone}\n" +
                    $"E-Posta : {dr.Email}\n" +
                    $"Branş : {dr.Field}\n" +
                    $"TC No : {dr.TcNo}";
                MessageBox.Show(msg, "Doktor Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDoctorDelete_Click(object sender, EventArgs e)
        {
            if (trvDoctorsCustomers.SelectedNode == null)
            {
                MessageBox.Show("Lütfen bir doktor seçiniz..", "Doktor Seçilmedi");
                return;
            }

            TreeNode tnDoc = trvDoctorsCustomers.SelectedNode;
            object obj = tnDoc.Tag;

            if (obj.GetType() != typeof(Doctor))
            {
                MessageBox.Show("Lütfen bir doktor seçiniz..", "Doktor Seçilmedi");
                return;
            }

            //Doctor doctor = (Doctor)tnDoc.Tag;        // tip uyuşmazlığında hata alınır.  
            Doctor doctor = tnDoc.Tag as Doctor;    // tip uyuşmazlığında null döner.

            if (doctor != null)
            {
                foreach (TreeNode tnCust in tnDoc.Nodes)
                {
                    Customers.Remove(tnCust.Tag as Customer);
                }

                Doctors.Remove(doctor);
            }

            LoadTreeView();
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if (trvDoctorsCustomers.SelectedNode == null)
            {
                MessageBox.Show("Lütfen bir hasta seçiniz..", "Hasta Seçilmedi");
                return;
            }

            TreeNode tn = trvDoctorsCustomers.SelectedNode;
            object obj = tn.Tag;

            if (obj.GetType() != typeof(Customer))
            {
                MessageBox.Show("Lütfen bir hasta seçiniz..", "Hasta Seçilmedi");
                return;
            }

            //Customer cus = (Customer)tn.Tag;        // tip uyuşmazlığında hata alınır.  
            Customer cus = tn.Tag as Customer;    // tip uyuşmazlığında null döner.

            if (cus != null)
            {
                Customers.Remove(cus);
            }

            LoadTreeView();
        }

        private void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            if (trvDoctorsCustomers.SelectedNode == null)
            {
                MessageBox.Show("Lütfen bir hasta seçiniz..", "Hasta Seçilmedi");
                return;
            }

            TreeNode tn = trvDoctorsCustomers.SelectedNode;

            object obj = tn.Tag;

            if (obj.GetType() != typeof(Customer))
            {
                MessageBox.Show("Lütfen bir hasta seçiniz..", "Hasta Seçilmedi");
                return;
            }

            Customer cus = tn.Tag as Customer;

            frmCustomerEdit frmCustomerEdit = new frmCustomerEdit();
            frmCustomerEdit.DoctorList = Doctors;
            frmCustomerEdit.CustomerData = cus;

            DialogResult result = frmCustomerEdit.ShowDialog();

            if (result == DialogResult.OK)
            {
                //foreach (Customer customer in Customers)
                //{
                //    if (customer.TcNo == cus.TcNo)
                //    {
                        string doctorTcNo = frmCustomerEdit.cmbDoctors.Text.Split('-')[1];

                        cus.FullName = frmCustomerEdit.txtCustomerName.Text.ToUpper();
                        cus.Phone = frmCustomerEdit.txtCustomerPhone.Text;
                        cus.Email = frmCustomerEdit.txtCustomerEmail.Text;
                        cus.BirthDate = frmCustomerEdit.dtpCustomerBirthDate.Value;
                        cus.Note = frmCustomerEdit.txtCustomerNote.Text;
                        cus.DoctorTcNo = doctorTcNo;
                        cus.TcNo = frmCustomerEdit.txtCustomerTcNo.Text;

                //        break;
                //    }
                //}

                LoadTreeView();
            }
        }

        private void btnDoctorEdit_Click(object sender, EventArgs e)
        {
            frmDoctorAdd frm = new frmDoctorAdd();
            //frm.Text = "Doktor Düzenle";
            //frm.btnAdd.Text = "Kaydet";
            frm.IsEdit = true;

            if (trvDoctorsCustomers.SelectedNode == null)
            {
                MessageBox.Show("Lütfen bir doktor seçiniz..", "Doktor Seçilmedi");
                return;
            }

            TreeNode tnDoc = trvDoctorsCustomers.SelectedNode;
            object obj = tnDoc.Tag;

            if (obj.GetType() != typeof(Doctor))
            {
                MessageBox.Show("Lütfen bir doktor seçiniz..", "Doktor Seçilmedi");
                return;
            }

            //Doctor doctor = (Doctor)tnDoc.Tag;        // tip uyuşmazlığında hata alınır.  
            Doctor doctor = tnDoc.Tag as Doctor;    // tip uyuşmazlığında null döner.

            frm.DoctorData = doctor;

            //frm.txtDoctorName.Text = doctor.FullName;
            //frm.txtDoctorEmail.Text = doctor.Email;
            //frm.txtDoctorPhone.Text = doctor.Phone;
            //frm.txtDoctorField.Text = doctor.Field;
            //frm.txtDoctorTcNo.Text = doctor.TcNo;

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.OK)
            {
                doctor.FullName = frm.txtDoctorName.Text.ToUpper();
                doctor.Phone = frm.txtDoctorPhone.Text;
                doctor.Email = frm.txtDoctorEmail.Text;
                doctor.Field = frm.txtDoctorField.Text;

                if (doctor.TcNo != frm.txtDoctorTcNo.Text)
                {
                    // hasta ların DoctorTcNo ları de güncellenmeli
                    foreach (TreeNode tnCus in tnDoc.Nodes)
                    {
                        Customer cus = tnCus.Tag as Customer;
                        cus.DoctorTcNo = frm.txtDoctorTcNo.Text;
                    }
                }

                doctor.TcNo = frm.txtDoctorTcNo.Text;

                LoadTreeView();
            }
        }
    }
}
