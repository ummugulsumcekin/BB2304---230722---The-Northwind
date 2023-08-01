namespace NorthwindProject.WinForms
{
    partial class EmployeeDeleteForm
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
            cmbEmployee = new ComboBox();
            label1 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(145, 46);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(309, 28);
            cmbEmployee.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 49);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Çalışan:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(310, 99);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(144, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Seçili olanı sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // EmployeeDeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(cmbEmployee);
            Name = "EmployeeDeleteForm";
            Text = "EmployeeDeleteForm";
            Load += EmployeeDeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEmployee;
        private Label label1;
        private Button btnDelete;
    }
}