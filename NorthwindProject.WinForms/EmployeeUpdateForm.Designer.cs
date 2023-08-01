namespace NorthwindProject.WinForms
{
    partial class EmployeeUpdateForm
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
            txtBirthDate = new MaskedTextBox();
            btnDelete = new Button();
            dtpHireDate = new DateTimePicker();
            txtTitle = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtTitleOfCourtesy = new TextBox();
            btnUpdate = new Button();
            cmbManager = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtBirthDate
            // 
            txtBirthDate.InsertKeyMode = InsertKeyMode.Overwrite;
            txtBirthDate.Location = new Point(175, 272);
            txtBirthDate.Mask = "00/00/0000";
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.Size = new Size(282, 27);
            txtBirthDate.TabIndex = 5;
            txtBirthDate.ValidatingType = typeof(DateTime);
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(636, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(175, 223);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(282, 27);
            dtpHireDate.TabIndex = 4;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(175, 125);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(282, 27);
            txtTitle.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(175, 78);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(282, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(175, 31);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(282, 27);
            txtFirstName.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 275);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 16;
            label5.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 228);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 15;
            label4.Text = "İşe Alım Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 128);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 14;
            label3.Text = "Görevi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 81);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 13;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 12;
            label1.Text = "Adı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 178);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 23;
            label6.Text = "Unvanı:";
            // 
            // txtTitleOfCourtesy
            // 
            txtTitleOfCourtesy.Location = new Point(175, 175);
            txtTitleOfCourtesy.Name = "txtTitleOfCourtesy";
            txtTitleOfCourtesy.Size = new Size(282, 27);
            txtTitleOfCourtesy.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(363, 391);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbManager
            // 
            cmbManager.FormattingEnabled = true;
            cmbManager.Location = new Point(175, 322);
            cmbManager.Name = "cmbManager";
            cmbManager.Size = new Size(282, 28);
            cmbManager.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 325);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 26;
            label7.Text = "Yöneticisi:";
            // 
            // EmployeeUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 450);
            Controls.Add(label7);
            Controls.Add(cmbManager);
            Controls.Add(btnUpdate);
            Controls.Add(txtTitleOfCourtesy);
            Controls.Add(label6);
            Controls.Add(txtBirthDate);
            Controls.Add(btnDelete);
            Controls.Add(dtpHireDate);
            Controls.Add(txtTitle);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmployeeUpdateForm";
            Text = "EmployeeUpdateForm";
            Load += EmployeeUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtBirthDate;
        private Button btnDelete;
        private DateTimePicker dtpHireDate;
        private TextBox txtTitle;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox txtTitleOfCourtesy;
        private Button btnUpdate;
        private ComboBox cmbManager;
        private Label label7;
    }
}