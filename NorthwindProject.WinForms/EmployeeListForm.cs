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
    public partial class EmployeeListForm : Form
    {
        private readonly EmployeeRepository _repo = new EmployeeRepository();

        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            LoadEmployeesData();
        }

        public void LoadEmployeesData()
        {
            gridEmployees.DataSource = _repo.GetAll();
        }

        private void gridEmployees_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                gridEmployees.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (gridEmployees.SelectedRows.Count > 0)
            {
                //var employee = (Employee)gridEmployees.SelectedRows[0].DataBoundItem;
                var employee = gridEmployees.SelectedRows[0].DataBoundItem as Employee;

                if (employee != null)
                {
                    var employeeUpdateForm = new EmployeeUpdateForm(employee.EmployeeID);
                    employeeUpdateForm.MdiParent = MdiParent;
                    employeeUpdateForm.Show();
                }
            }
        }
    }
}
