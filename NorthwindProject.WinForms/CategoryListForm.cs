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
    public partial class CategoryListForm : Form
    {
        private readonly CategoryRepository _categoryRepostiory = new CategoryRepository();

        public CategoryListForm()
        {
            InitializeComponent();
        }

        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            var categories = _categoryRepostiory.GetAll();

            // Bind
            gridCategories.DataSource = categories;
        }

        private void gridCategories_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                //var grid = gridCategories; // Grid'in
                //var allRows = grid.Rows; // tüm satırları arasından
                //var clickedRow = allRows[e.RowIndex]; // click'lenen satırı bul
                //clickedRow.Selected = true; // onu selected duruma getir

                gridCategories.Rows[e.RowIndex].Selected = true;
            }
        }

        private void menuDeleteCategory_Click(object sender, EventArgs e)
        {
            if (gridCategories.SelectedRows.Count > 0)
            {
                var category = (Category)gridCategories.SelectedRows[0].DataBoundItem;
                bool result = _categoryRepostiory.Remove(category);

                if (result)
                {

                }
                else
                {

                }
            }
        }

        private void menuUpdateCategory_Click(object sender, EventArgs e)
        {
            if (gridCategories.SelectedRows.Count > 0)
            {
                var category = (Category)gridCategories.SelectedRows[0].DataBoundItem;

                var categoryUpdateForm = new CategoryUpdateForm(category.CategoryID);

            }
        }
    }
}
