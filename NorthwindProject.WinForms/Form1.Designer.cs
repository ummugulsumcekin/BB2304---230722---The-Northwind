namespace NorthwindProject.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            kategoriYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menuNewCategory = new ToolStripMenuItem();
            menuCategoryList = new ToolStripMenuItem();
            ürünYönetimiToolStripMenuItem = new ToolStripMenuItem();
            menuNewProduct = new ToolStripMenuItem();
            menuProductList = new ToolStripMenuItem();
            personelYönetimiToolStripMenuItem = new ToolStripMenuItem();
            yeniPersoToolStripMenuItem = new ToolStripMenuItem();
            menuEmployeeList = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuDeleteEmployee = new ToolStripMenuItem();
            siparişYönetimiToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            menuNewOrder = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { kategoriYönetimiToolStripMenuItem, ürünYönetimiToolStripMenuItem, personelYönetimiToolStripMenuItem, siparişYönetimiToolStripMenuItem, raporlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            kategoriYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNewCategory, menuCategoryList });
            kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            kategoriYönetimiToolStripMenuItem.Size = new Size(142, 24);
            kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // menuNewCategory
            // 
            menuNewCategory.Name = "menuNewCategory";
            menuNewCategory.Size = new Size(224, 26);
            menuNewCategory.Text = "Yeni Kategori";
            menuNewCategory.Click += menuNewCategory_Click;
            // 
            // menuCategoryList
            // 
            menuCategoryList.Name = "menuCategoryList";
            menuCategoryList.Size = new Size(224, 26);
            menuCategoryList.Text = "Tüm Kategoriler";
            menuCategoryList.Click += menuCategoryList_Click;
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNewProduct, menuProductList });
            ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            ürünYönetimiToolStripMenuItem.Size = new Size(116, 24);
            ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuNewProduct
            // 
            menuNewProduct.Name = "menuNewProduct";
            menuNewProduct.Size = new Size(224, 26);
            menuNewProduct.Text = "Yeni Ürün";
            menuNewProduct.Click += menuNewProduct_Click;
            // 
            // menuProductList
            // 
            menuProductList.Name = "menuProductList";
            menuProductList.Size = new Size(224, 26);
            menuProductList.Text = "Tüm Ürünler";
            menuProductList.Click += menuProductList_Click;
            // 
            // personelYönetimiToolStripMenuItem
            // 
            personelYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniPersoToolStripMenuItem, menuEmployeeList, toolStripSeparator1, menuDeleteEmployee });
            personelYönetimiToolStripMenuItem.Name = "personelYönetimiToolStripMenuItem";
            personelYönetimiToolStripMenuItem.Size = new Size(140, 24);
            personelYönetimiToolStripMenuItem.Text = "Personel Yönetimi";
            // 
            // yeniPersoToolStripMenuItem
            // 
            yeniPersoToolStripMenuItem.Name = "yeniPersoToolStripMenuItem";
            yeniPersoToolStripMenuItem.Size = new Size(224, 26);
            yeniPersoToolStripMenuItem.Text = "Yeni Personel";
            // 
            // menuEmployeeList
            // 
            menuEmployeeList.Name = "menuEmployeeList";
            menuEmployeeList.Size = new Size(224, 26);
            menuEmployeeList.Text = "Tüm Personeller";
            menuEmployeeList.Click += menuEmployeeList_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // menuDeleteEmployee
            // 
            menuDeleteEmployee.Name = "menuDeleteEmployee";
            menuDeleteEmployee.Size = new Size(224, 26);
            menuDeleteEmployee.Text = "Personel silme";
            menuDeleteEmployee.Click += menuDeleteEmployee_Click;
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuNewOrder });
            siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            siparişYönetimiToolStripMenuItem.Size = new Size(129, 24);
            siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(80, 24);
            raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // menuNewOrder
            // 
            menuNewOrder.Name = "menuNewOrder";
            menuNewOrder.Size = new Size(224, 26);
            menuNewOrder.Text = "Yeni Sipariş";
            menuNewOrder.Click += menuNewOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuNewCategory;
        private ToolStripMenuItem menuCategoryList;
        private ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuNewProduct;
        private ToolStripMenuItem menuProductList;
        private ToolStripMenuItem personelYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuEmployeeList;
        private ToolStripMenuItem yeniPersoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuDeleteEmployee;
        private ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private ToolStripMenuItem menuNewOrder;
        private ToolStripMenuItem raporlarToolStripMenuItem;
    }
}