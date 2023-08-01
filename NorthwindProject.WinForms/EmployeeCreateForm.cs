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
    public partial class EmployeeCreateForm : Form
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();

        public EmployeeCreateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Entity nesneyi oluştur
            var employee = new Employee();
            employee.FirstName = textBox1.Text;
            employee.LastName = textBox2.Text;
            employee.Title = textBox3.Text;

            // Gelişmiş DateTimePicker kontrollerine ihtiyacımız var
            // Telerik, DevExpress, ComponentOne
            // Syncfusion (Community License)
            // VueJS -> Quasar
            employee.HireDate = dateTimePicker1.Value;

            if (DateTime.TryParse(maskedTextBox1.Text, out DateTime birthDate))
            {
                employee.BirthDate = birthDate;
            }

            // Bu nesneyi işi yapacak olan (Repository/Service,Manager)
            // işçi nesnenin ilgili metoduna (Add, Update, Remove) gönder

            // Sonucu değerlendir
        }

        private void EmployeeCreateForm_Load(object sender, EventArgs e)
        {
            var allEmployees = _employeeRepository.GetAll();
            cmbManager.DataSource = allEmployees;
            cmbManager.ValueMember = "EmployeeID";
            cmbManager.DisplayMember = "FullName";
        }
    }
}
