using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindProject.DataAccess;
using NorthwindProject.Entities;

namespace NorthwindProject.WinForms
{
    public partial class EmployeeDeleteForm : Form
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();

        public EmployeeDeleteForm()
        {
            InitializeComponent();
        }

        private void EmployeeDeleteForm_Load(object sender, EventArgs e)
        {
            //cmbEmployee.DataSource = _employeeRepository.GetAll();
            //cmbEmployee.DisplayMember = "FullName";

            var employees = _employeeRepository.GetAll();

            for (int i = 0; i < employees.Count; i++)
            {
                var radioButton = new RadioButton();
                radioButton.Text = employees[i].FullName;
                radioButton.Top = 100 + i * 25;
                radioButton.Left = 50;
                radioButton.AutoSize = true;

                Controls.Add(radioButton);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbEmployee.SelectedIndex > -1)
            {
                var employee = cmbEmployee.SelectedItem as Employee;

                if (employee != null)
                {
                    var result = _employeeRepository.Remove(employee);
                    var resultMessage = result ? "Silme işlemi başarılı" : "Kayıt silinemedi";

                    MessageBox.Show(resultMessage);
                }
            }
        }
    }
}
