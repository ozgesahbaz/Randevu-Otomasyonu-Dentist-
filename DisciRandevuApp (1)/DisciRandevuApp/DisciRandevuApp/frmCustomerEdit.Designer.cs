
namespace DisciRandevuApp
{
    partial class frmCustomerEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDoctors = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.dtpCustomerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerNote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustomerTcNo = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(180, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor";
            // 
            // cmbDoctors
            // 
            this.cmbDoctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctors.FormattingEnabled = true;
            this.cmbDoctors.Location = new System.Drawing.Point(16, 51);
            this.cmbDoctors.Name = "cmbDoctors";
            this.cmbDoctors.Size = new System.Drawing.Size(320, 29);
            this.cmbDoctors.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 36);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hasta Ad && Soyad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(16, 122);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(321, 29);
            this.txtCustomerName.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hasta Telefon";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(16, 193);
            this.txtCustomerPhone.Mask = "(999) 000-0000";
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(321, 29);
            this.txtCustomerPhone.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 36);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hasta E-Posta Adresi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 613);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(349, 60);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(261, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(16, 264);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(321, 29);
            this.txtCustomerEmail.TabIndex = 19;
            // 
            // dtpCustomerBirthDate
            // 
            this.dtpCustomerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCustomerBirthDate.Location = new System.Drawing.Point(16, 335);
            this.dtpCustomerBirthDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.dtpCustomerBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpCustomerBirthDate.Name = "dtpCustomerBirthDate";
            this.dtpCustomerBirthDate.Size = new System.Drawing.Size(320, 29);
            this.dtpCustomerBirthDate.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 36);
            this.label6.TabIndex = 22;
            this.label6.Text = "Hasta Not";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCustomerNote
            // 
            this.txtCustomerNote.Location = new System.Drawing.Point(16, 406);
            this.txtCustomerNote.Multiline = true;
            this.txtCustomerNote.Name = "txtCustomerNote";
            this.txtCustomerNote.PlaceholderText = "Hasta ile ilgili not alabilirsiniz.";
            this.txtCustomerNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustomerNote.Size = new System.Drawing.Size(321, 114);
            this.txtCustomerNote.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 36);
            this.label7.TabIndex = 24;
            this.label7.Text = "Hasta TC No";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtCustomerTcNo
            // 
            this.txtCustomerTcNo.Location = new System.Drawing.Point(16, 562);
            this.txtCustomerTcNo.Mask = "00000000000";
            this.txtCustomerTcNo.Name = "txtCustomerTcNo";
            this.txtCustomerTcNo.Size = new System.Drawing.Size(321, 29);
            this.txtCustomerTcNo.TabIndex = 25;
            this.txtCustomerTcNo.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 36);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hasta Doğum Tarihi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.cmbDoctors);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtCustomerName);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtCustomerPhone);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtCustomerEmail);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.dtpCustomerBirthDate);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.txtCustomerNote);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.txtCustomerTcNo);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(349, 673);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // frmCustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 673);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomerEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Düzenle";
            this.Load += new System.EventHandler(this.frmCustomerEdit_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbDoctors;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox txtCustomerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtCustomerEmail;
        public System.Windows.Forms.DateTimePicker dtpCustomerBirthDate;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCustomerNote;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox txtCustomerTcNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}