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
    public partial class CategoryCreateForm : Form
    {
        private CategoryRepository _categoryRepository = new CategoryRepository();

        public CategoryCreateForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var category = new Category()
            {
                CategoryName = txtCategoryName.Text,
                Description = txtDescription.Text
            };

            var result = _categoryRepository.Add(category);

            if (result)
            {

            }
            else
            {
                MessageBox.Show("bir hata meydana geldi");
            }
        }
    }
}
