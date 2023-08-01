namespace NorthwindProject.WinForms
{
    partial class ProductCreateForm
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
            btnSave = new Button();
            chkIsActive = new CheckBox();
            txtReorderLevel = new MaskedTextBox();
            txtUnitsOnOrder = new MaskedTextBox();
            txtUnitsInStock = new MaskedTextBox();
            numUnitPrice = new NumericUpDown();
            txtQuantityPerUnit = new TextBox();
            cmbSupplierId = new ComboBox();
            cmbCategoryId = new ComboBox();
            txtProductName = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(307, 429);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 37;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(149, 388);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(62, 24);
            chkIsActive.TabIndex = 36;
            chkIsActive.Text = "Aktif";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtReorderLevel
            // 
            txtReorderLevel.Location = new Point(149, 341);
            txtReorderLevel.Mask = "00000";
            txtReorderLevel.Name = "txtReorderLevel";
            txtReorderLevel.Size = new Size(252, 27);
            txtReorderLevel.TabIndex = 35;
            txtReorderLevel.ValidatingType = typeof(int);
            // 
            // txtUnitsOnOrder
            // 
            txtUnitsOnOrder.Location = new Point(149, 296);
            txtUnitsOnOrder.Mask = "00000";
            txtUnitsOnOrder.Name = "txtUnitsOnOrder";
            txtUnitsOnOrder.Size = new Size(252, 27);
            txtUnitsOnOrder.TabIndex = 34;
            txtUnitsOnOrder.ValidatingType = typeof(int);
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(149, 251);
            txtUnitsInStock.Mask = "00000";
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.PromptChar = ' ';
            txtUnitsInStock.Size = new Size(252, 27);
            txtUnitsInStock.TabIndex = 33;
            txtUnitsInStock.ValidatingType = typeof(int);
            txtUnitsInStock.Click += txtUnitsInStock_Click;
            txtUnitsInStock.Enter += txtUnitsInStock_Enter;
            // 
            // numUnitPrice
            // 
            numUnitPrice.Location = new Point(149, 207);
            numUnitPrice.Name = "numUnitPrice";
            numUnitPrice.Size = new Size(252, 27);
            numUnitPrice.TabIndex = 32;
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.Location = new Point(149, 161);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(252, 27);
            txtQuantityPerUnit.TabIndex = 31;
            // 
            // cmbSupplierId
            // 
            cmbSupplierId.FormattingEnabled = true;
            cmbSupplierId.Location = new Point(149, 116);
            cmbSupplierId.Name = "cmbSupplierId";
            cmbSupplierId.Size = new Size(252, 28);
            cmbSupplierId.TabIndex = 30;
            // 
            // cmbCategoryId
            // 
            cmbCategoryId.FormattingEnabled = true;
            cmbCategoryId.Location = new Point(149, 71);
            cmbCategoryId.Name = "cmbCategoryId";
            cmbCategoryId.Size = new Size(252, 28);
            cmbCategoryId.TabIndex = 29;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(149, 26);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(252, 27);
            txtProductName.TabIndex = 28;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 389);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 27;
            label9.Text = "Ürün Durumu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 344);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 26;
            label8.Text = "Kritik Stok Eşiği:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 299);
            label7.Name = "label7";
            label7.Size = new Size(97, 20);
            label7.TabIndex = 25;
            label7.Text = "Gelecek Stok:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 254);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 24;
            label6.Text = "Stok Miktarı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 209);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 23;
            label5.Text = "Birim Fiyatı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 164);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 22;
            label4.Text = "Birim içeriği:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 119);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 21;
            label3.Text = "Tedarikçi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 74);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 20;
            label2.Text = "Kategorisi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 29);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 19;
            label1.Text = "Ürün Adı:";
            // 
            // ProductCreateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(btnSave);
            Controls.Add(chkIsActive);
            Controls.Add(txtReorderLevel);
            Controls.Add(txtUnitsOnOrder);
            Controls.Add(txtUnitsInStock);
            Controls.Add(numUnitPrice);
            Controls.Add(txtQuantityPerUnit);
            Controls.Add(cmbSupplierId);
            Controls.Add(cmbCategoryId);
            Controls.Add(txtProductName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductCreateForm";
            Text = "ProductCreateForm";
            Load += ProductCreateForm_Load;
            ((System.ComponentModel.ISupportInitialize)numUnitPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private CheckBox chkIsActive;
        private MaskedTextBox txtReorderLevel;
        private MaskedTextBox txtUnitsOnOrder;
        private MaskedTextBox txtUnitsInStock;
        private NumericUpDown numUnitPrice;
        private TextBox txtQuantityPerUnit;
        private ComboBox cmbSupplierId;
        private ComboBox cmbCategoryId;
        private TextBox txtProductName;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}