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
    public partial class EmployeeUpdateForm : Form
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();
        private readonly int _employeeId;

        public EmployeeUpdateForm(int employeeId)
        {
            _employeeId = employeeId;

            InitializeComponent();
        }

        private void EmployeeUpdateForm_Load(object sender, EventArgs e)
        {
            FillManagerComboBox();

            var employee = _employeeRepository.Find(_employeeId);

            if (employee != null)
            {
                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
                txtTitle.Text = employee.Title;
                txtTitleOfCourtesy.Text = employee.TitleOfCourtesy;
                dtpHireDate.Value = employee.HireDate ?? DateTime.Today;
                txtBirthDate.Text = employee.BirthDate?.ToString("MM/dd/yyyy");

                if (employee.ReportsTo.HasValue)
                    cmbManager.SelectedValue = employee.ReportsTo.Value;
            }
        }

        private void FillManagerComboBox()
        {
            cmbManager.DataSource = _employeeRepository.GetAll();
            cmbManager.DisplayMember = "FullName";
            cmbManager.ValueMember = "EmployeeID";
            cmbManager.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Bu kaydı silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo);

            if (messageBoxResult == DialogResult.Yes)
            {
                var employee = new Employee() { EmployeeID = _employeeId };

                _employeeRepository.Remove(employee);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime? birthDate = default;
            if (DateTime.TryParse(txtBirthDate.Text, out DateTime parsedDate))
                birthDate = parsedDate;

            var employee = new Employee()
            {
                EmployeeID = _employeeId,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Title = txtTitle.Text,
                TitleOfCourtesy = txtTitleOfCourtesy.Text,
                HireDate = dtpHireDate.Value,
                BirthDate = birthDate,
                ReportsTo = (int?)cmbManager.SelectedValue
            };

            var result = _employeeRepository.Update(employee);

            if (result)
            {
                MessageBox.Show("Güncelleme başarılı");
                // Form1 içinde açık olan EmployeeListFormları bul, Data refresh işlemi yap

                //for (int i = 0; i < MdiParent.MdiChildren.Length; i++)
                //{
                //    Form form = MdiParent.MdiChildren[i];

                //    if (form is EmployeeListForm)
                //    {
                //        var employeeListForm = (EmployeeListForm)form;
                //        employeeListForm.LoadEmployeesData();
                //    }
                //}

                foreach (var form in MdiParent.MdiChildren)
                {
                    if (form is EmployeeListForm)
                    {
                        var employeeListForm = (EmployeeListForm)form;
                        employeeListForm.LoadEmployeesData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız");
            }
        }
    }
}
