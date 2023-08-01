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

namespace NorthwindProject.WinForms
{
    public partial class ProductUpdateForm : Form
    {
        public ProductUpdateForm()
        {
            InitializeComponent();
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            var categoryRepo = new CategoryRepository();
            var categories = categoryRepo.GetAll();
            cmbCategoryId.DataSource = categories;
            cmbCategoryId.DisplayMember = "CategoryName";
            cmbCategoryId.ValueMember = "CategoryID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
