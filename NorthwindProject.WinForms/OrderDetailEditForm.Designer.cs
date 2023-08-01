namespace NorthwindProject.WinForms
{
    partial class OrderDetailEditForm
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
            cmbProduct = new ComboBox();
            numQuantity = new NumericUpDown();
            txtUnitPrice = new TextBox();
            numDiscount = new NumericUpDown();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "Ürün:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 89);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "Fiyat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 145);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Miktar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 201);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "İndirim: (%)";
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(148, 30);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(250, 28);
            cmbProduct.TabIndex = 4;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            cmbProduct.SelectedValueChanged += cmbProduct_SelectedValueChanged;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(148, 143);
            numQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(250, 27);
            numQuantity.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(148, 86);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(250, 27);
            txtUnitPrice.TabIndex = 7;
            // 
            // numDiscount
            // 
            numDiscount.Location = new Point(148, 199);
            numDiscount.Name = "numDiscount";
            numDiscount.Size = new Size(250, 27);
            numDiscount.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(304, 271);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // OrderDetailEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 381);
            Controls.Add(btnAdd);
            Controls.Add(numDiscount);
            Controls.Add(txtUnitPrice);
            Controls.Add(numQuantity);
            Controls.Add(cmbProduct);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OrderDetailEditForm";
            Text = "OrderDetailEditForm";
            Load += OrderDetailEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbProduct;
        private NumericUpDown numQuantity;
        private TextBox txtUnitPrice;
        private NumericUpDown numDiscount;
        private Button btnAdd;
    }
}