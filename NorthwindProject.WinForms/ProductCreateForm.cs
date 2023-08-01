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
    public partial class ProductCreateForm : Form
    {
        // private readonly CategoryService
        private readonly CategoryRepository _categoryRepository = new CategoryRepository();
        private readonly SupplierRepository _supplierRepository = new SupplierRepository();
        private readonly ProductRepository _productRepository = new ProductRepository();

        public ProductCreateForm()
        {
            InitializeComponent();
        }

        private void ProductCreateForm_Load(object sender, EventArgs e)
        {
            var categories = _categoryRepository.GetAll();
            cmbCategoryId.DataSource = categories;
            cmbCategoryId.DisplayMember = "CategoryName";
            cmbCategoryId.ValueMember = "CategoryID";

            var suppliers = _supplierRepository.GetAll();
            cmbSupplierId.DataSource = suppliers;
            cmbSupplierId.DisplayMember = "CompanyName";
            cmbSupplierId.ValueMember = "SupplierID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitsInStock_Enter(object sender, EventArgs e)
        {
            
        }

        // MaskedTextBox'a tıklanınca imlecin, metin kutusu içerisinde yazılı ifadenin en sonuna
        // gelmesi için yaptığımız deneme. Önemli bir şey değil
        private void txtUnitsInStock_Click(object sender, EventArgs e)
        {
            txtUnitsInStock.Select(txtUnitsInStock.Text.Length, 0);
        }
    }
}
