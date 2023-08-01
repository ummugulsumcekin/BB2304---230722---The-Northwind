namespace NorthwindProject.WinForms
{
    public partial class Form1 : Form
    {
        /*
            Seperation of Concerns

            Veri iþlemlerini form projesinden ayrýþtýracaðýz

            Repository Pattern

            class CategoryRepository
            Kategori deposu

            -- QUERY
            -- Read
            GetAll()
            GetById(int categoryId), Find(int categoryId)

            -- COMMAND
            -- Create
            Add(Category category)

            -- Update
            Update(Category category)

            -- Delete
            Remove(Category category)
            Remove(int categoryId)

            Her entity için yazacaðýmýz Repository sýnýflarýnda standart CRUD iþlemlerini
            implement edeceðiz

            Repository nesnelerimiz DB ile konuþacak, Form nesneleri ise Repository ile
            iletiþim kuracak
         */

        /*
         * SORULAR 26.7.23
         * 1. Veritabanýndan DateTime tarih deðeri baþýnda 0 olmayacak þekilde 1.7.1993 örneðinde olduðu gibi gelince bu deðeri
         * MaskedTextBox'a yüklerken deðer 17/19/93__ gibi görünüyor. Bunun çözümü nasýl olmalý?
         * 2. Ekrandaki kontrollerin Tab sýralamasý bozulunca bunu nasýl düzeltebiliriz?
         * 3. Silme iþlemi için baþlangýcý Grid'den deðil de ComboBox'tan yapabilir miyiz?
         * 4. Formlardan ekleme/silme/güncelleme yaptýktan sonra o entity ile ilgili Grid'lerin (ListForm'larýn)
         * otomatik güncellenmesi
         * 5. MaskedTextBox'a týklayýnca imleç en sonda kalýyor
         * ---------------------------------------------------------------------------------------
         * 6. Resim alanlarýný kaydet/güncelleme aþamasýnda nasýl bir yol izleyebiliriz? Hangi kontrolü kullanmalý
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void menuNewCategory_Click(object sender, EventArgs e)
        {
            var categoryCreateForm = new CategoryCreateForm();
            categoryCreateForm.MdiParent = this;
            categoryCreateForm.Show();
        }

        private void menuCategoryList_Click(object sender, EventArgs e)
        {
            var categoryListForm = new CategoryListForm();
            categoryListForm.MdiParent = this;
            categoryListForm.Show();
        }

        private void menuNewProduct_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreateForm();
            productCreateForm.MdiParent = this;
            productCreateForm.Show();
        }

        private void menuProductList_Click(object sender, EventArgs e)
        {
            var productListForm = new ProductListForm();
            productListForm.MdiParent = this;
            productListForm.Show();
        }

        private void menuEmployeeList_Click(object sender, EventArgs e)
        {
            var employeeListForm = new EmployeeListForm();
            employeeListForm.MdiParent = this;
            employeeListForm.Show();
        }

        private void menuDeleteEmployee_Click(object sender, EventArgs e)
        {
            var employeeDeleteForm = new EmployeeDeleteForm();
            employeeDeleteForm.MdiParent = this;
            employeeDeleteForm.Show();
        }

        private void CustomerIdComparison()
        {
            string customerIdDb = "TSU  ";

            string customerIdInput = "TSU";

            if (customerIdDb.Trim() == customerIdInput.Trim())
            {

            }
        }

        private void menuNewOrder_Click(object sender, EventArgs e)
        {
            var orderCreateForm = new OrderCreateForm();
            orderCreateForm.MdiParent = this;
            orderCreateForm.Show();
        }
    }
}