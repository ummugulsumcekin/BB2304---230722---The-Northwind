namespace NorthwindProject.WinForms
{
    partial class CategoryListForm
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
            components = new System.ComponentModel.Container();
            gridCategories = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            menuUpdateCategory = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuDeleteCategory = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)gridCategories).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gridCategories
            // 
            gridCategories.AllowUserToAddRows = false;
            gridCategories.AllowUserToDeleteRows = false;
            gridCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategories.Dock = DockStyle.Fill;
            gridCategories.Location = new Point(0, 0);
            gridCategories.MultiSelect = false;
            gridCategories.Name = "gridCategories";
            gridCategories.ReadOnly = true;
            gridCategories.RowHeadersWidth = 51;
            gridCategories.RowTemplate.ContextMenuStrip = contextMenuStrip1;
            gridCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCategories.Size = new Size(800, 450);
            gridCategories.TabIndex = 1;
            gridCategories.CellMouseDown += gridCategories_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { güncelleToolStripMenuItem, menuUpdateCategory, toolStripSeparator1, menuDeleteCategory });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(135, 82);
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(134, 24);
            güncelleToolStripMenuItem.Text = "Detaylar";
            // 
            // menuUpdateCategory
            // 
            menuUpdateCategory.Name = "menuUpdateCategory";
            menuUpdateCategory.Size = new Size(134, 24);
            menuUpdateCategory.Text = "Düzenle";
            menuUpdateCategory.Click += menuUpdateCategory_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(131, 6);
            // 
            // menuDeleteCategory
            // 
            menuDeleteCategory.Name = "menuDeleteCategory";
            menuDeleteCategory.Size = new Size(134, 24);
            menuDeleteCategory.Text = "Sil";
            menuDeleteCategory.Click += menuDeleteCategory_Click;
            // 
            // CategoryListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridCategories);
            Name = "CategoryListForm";
            Text = "CategoryListForm";
            Load += CategoryListForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridCategories).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCategories;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuDeleteCategory;
        private ToolStripMenuItem menuUpdateCategory;
    }
}