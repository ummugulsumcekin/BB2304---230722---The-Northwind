namespace NorthwindProject.WinForms
{
    partial class OrderCreateForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbCustomer = new ComboBox();
            cmbEmployee = new ComboBox();
            dtpOrderDate = new DateTimePicker();
            dtpRequiredDate = new DateTimePicker();
            dtpShippedDate = new DateTimePicker();
            cmbShipper = new ComboBox();
            numFreight = new NumericUpDown();
            txtShipName = new TextBox();
            txtShipAddress = new TextBox();
            txtShipCity = new TextBox();
            txtShipRegion = new TextBox();
            txtShipPostalCode = new TextBox();
            txtShipCountry = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            gridOrderDetails = new DataGridView();
            label14 = new Label();
            btnAddProduct = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numFreight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Müşteri:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 79);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Çalışan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 130);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Sipariş Tarihi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 181);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 3;
            label4.Text = "Termin Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 232);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 4;
            label5.Text = "Gönderi Tarihi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 283);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 5;
            label6.Text = "Lojistik Firma:";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(156, 28);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(266, 28);
            cmbCustomer.TabIndex = 6;
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(156, 76);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(266, 28);
            cmbEmployee.TabIndex = 7;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(156, 125);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(266, 27);
            dtpOrderDate.TabIndex = 8;
            // 
            // dtpRequiredDate
            // 
            dtpRequiredDate.Location = new Point(156, 176);
            dtpRequiredDate.Name = "dtpRequiredDate";
            dtpRequiredDate.Size = new Size(266, 27);
            dtpRequiredDate.TabIndex = 9;
            // 
            // dtpShippedDate
            // 
            dtpShippedDate.Location = new Point(156, 227);
            dtpShippedDate.Name = "dtpShippedDate";
            dtpShippedDate.Size = new Size(266, 27);
            dtpShippedDate.TabIndex = 10;
            // 
            // cmbShipper
            // 
            cmbShipper.FormattingEnabled = true;
            cmbShipper.Location = new Point(156, 280);
            cmbShipper.Name = "cmbShipper";
            cmbShipper.Size = new Size(266, 28);
            cmbShipper.TabIndex = 11;
            // 
            // numFreight
            // 
            numFreight.Location = new Point(156, 334);
            numFreight.Name = "numFreight";
            numFreight.Size = new Size(266, 27);
            numFreight.TabIndex = 12;
            // 
            // txtShipName
            // 
            txtShipName.Location = new Point(600, 21);
            txtShipName.Name = "txtShipName";
            txtShipName.Size = new Size(266, 27);
            txtShipName.TabIndex = 13;
            // 
            // txtShipAddress
            // 
            txtShipAddress.Location = new Point(600, 76);
            txtShipAddress.Name = "txtShipAddress";
            txtShipAddress.Size = new Size(266, 27);
            txtShipAddress.TabIndex = 13;
            // 
            // txtShipCity
            // 
            txtShipCity.Location = new Point(600, 127);
            txtShipCity.Name = "txtShipCity";
            txtShipCity.Size = new Size(266, 27);
            txtShipCity.TabIndex = 13;
            // 
            // txtShipRegion
            // 
            txtShipRegion.Location = new Point(600, 176);
            txtShipRegion.Name = "txtShipRegion";
            txtShipRegion.Size = new Size(266, 27);
            txtShipRegion.TabIndex = 13;
            // 
            // txtShipPostalCode
            // 
            txtShipPostalCode.Location = new Point(600, 227);
            txtShipPostalCode.Name = "txtShipPostalCode";
            txtShipPostalCode.Size = new Size(266, 27);
            txtShipPostalCode.TabIndex = 13;
            // 
            // txtShipCountry
            // 
            txtShipCountry.Location = new Point(600, 276);
            txtShipCountry.Name = "txtShipCountry";
            txtShipCountry.Size = new Size(266, 27);
            txtShipCountry.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(497, 28);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 14;
            label7.Text = "Alıcı Adı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(497, 79);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 14;
            label8.Text = "Açık Adres:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(497, 130);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 14;
            label9.Text = "Şehir:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(497, 179);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 14;
            label10.Text = "Bölgesi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(497, 230);
            label11.Name = "label11";
            label11.Size = new Size(86, 20);
            label11.TabIndex = 14;
            label11.Text = "Posta Kodu:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(497, 279);
            label12.Name = "label12";
            label12.Size = new Size(41, 20);
            label12.TabIndex = 14;
            label12.Text = "Ülke:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 336);
            label13.Name = "label13";
            label13.Size = new Size(58, 20);
            label13.TabIndex = 15;
            label13.Text = "Navlun:";
            // 
            // gridOrderDetails
            // 
            gridOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridOrderDetails.Location = new Point(34, 411);
            gridOrderDetails.Name = "gridOrderDetails";
            gridOrderDetails.RowHeadersWidth = 51;
            gridOrderDetails.RowTemplate.Height = 29;
            gridOrderDetails.Size = new Size(829, 198);
            gridOrderDetails.TabIndex = 16;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(37, 385);
            label14.Name = "label14";
            label14.Size = new Size(60, 20);
            label14.TabIndex = 17;
            label14.Text = "Ürünler:";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(736, 376);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(130, 29);
            btnAddProduct.TabIndex = 18;
            btnAddProduct.Text = "Ürün Ekle";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(757, 630);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 29);
            btnSave.TabIndex = 19;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // OrderCreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 693);
            Controls.Add(btnSave);
            Controls.Add(btnAddProduct);
            Controls.Add(label14);
            Controls.Add(gridOrderDetails);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtShipCountry);
            Controls.Add(txtShipPostalCode);
            Controls.Add(txtShipRegion);
            Controls.Add(txtShipCity);
            Controls.Add(txtShipAddress);
            Controls.Add(txtShipName);
            Controls.Add(numFreight);
            Controls.Add(cmbShipper);
            Controls.Add(dtpShippedDate);
            Controls.Add(dtpRequiredDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(cmbEmployee);
            Controls.Add(cmbCustomer);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderCreateForm";
            Text = "Yeni Sipariş";
            Load += OrderCreateForm_Load;
            ((System.ComponentModel.ISupportInitialize)numFreight).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbCustomer;
        private ComboBox cmbEmployee;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpRequiredDate;
        private DateTimePicker dtpShippedDate;
        private ComboBox cmbShipper;
        private NumericUpDown numFreight;
        private TextBox txtShipName;
        private TextBox txtShipAddress;
        private TextBox txtShipCity;
        private TextBox txtShipRegion;
        private TextBox txtShipPostalCode;
        private TextBox txtShipCountry;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView gridOrderDetails;
        private Label label14;
        private Button btnAddProduct;
        private Button btnSave;
    }
}