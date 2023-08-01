namespace NorthwindProject.WinForms
{
    partial class EmployeeListForm
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
            gridEmployees = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuUpdateEmployee = new ToolStripMenuItem();
            menuDeleteEmployee = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)gridEmployees).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // gridEmployees
            // 
            gridEmployees.AllowUserToAddRows = false;
            gridEmployees.AllowUserToDeleteRows = false;
            gridEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridEmployees.Dock = DockStyle.Fill;
            gridEmployees.Location = new Point(0, 0);
            gridEmployees.MultiSelect = false;
            gridEmployees.Name = "gridEmployees";
            gridEmployees.ReadOnly = true;
            gridEmployees.RowHeadersWidth = 51;
            gridEmployees.RowTemplate.ContextMenuStrip = contextMenuStrip1;
            gridEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEmployees.Size = new Size(800, 450);
            gridEmployees.TabIndex = 0;
            gridEmployees.CellMouseDown += gridEmployees_CellMouseDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { menuUpdateEmployee, menuDeleteEmployee });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 80);
            // 
            // menuUpdateEmployee
            // 
            menuUpdateEmployee.Name = "menuUpdateEmployee";
            menuUpdateEmployee.Size = new Size(210, 24);
            menuUpdateEmployee.Text = "Düzenle";
            menuUpdateEmployee.Click += menuUpdateEmployee_Click;
            // 
            // menuDeleteEmployee
            // 
            menuDeleteEmployee.Name = "menuDeleteEmployee";
            menuDeleteEmployee.Size = new Size(210, 24);
            menuDeleteEmployee.Text = "Sil";
            // 
            // EmployeeListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridEmployees);
            Name = "EmployeeListForm";
            Text = "EmployeeListForm";
            Load += EmployeeListForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridEmployees).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridEmployees;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem menuUpdateEmployee;
        private ToolStripMenuItem menuDeleteEmployee;
    }
}