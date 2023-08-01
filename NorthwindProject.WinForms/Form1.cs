namespace NorthwindProject.WinForms
{
    public partial class Form1 : Form
    {
        /*
            Seperation of Concerns

            Veri i�lemlerini form projesinden ayr��t�raca��z

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

            Her entity i�in yazaca��m�z Repository s�n�flar�nda standart CRUD i�lemlerini
            implement edece�iz

            Repository nesnelerimiz DB ile konu�acak, Form nesneleri ise Repository ile
            ileti�im kuracak
         */

        /*
         * SORULAR 26.7.23
         * 1. Veritaban�ndan DateTime tarih de�eri ba��nda 0 olmayacak �ekilde 1.7.1993 �rne�inde oldu�u gibi gelince bu de�eri
         * MaskedTextBox'a y�klerken de�er 17/19/93__ gibi g�r�n�yor. Bunun ��z�m� nas�l olmal�?
         * 2. Ekrandaki kontrollerin Tab s�ralamas� bozulunca bunu nas�l d�zeltebiliriz?
         * 3. Silme i�lemi i�in ba�lang�c� Grid'den de�il de ComboBox'tan yapabilir miyiz?
         * 4. Formlardan ekleme/silme/g�ncelleme yapt�ktan sonra o entity ile ilgili Grid'lerin (ListForm'lar�n)
         * otomatik g�ncellenmesi
         * 5. MaskedTextBox'a t�klay�nca imle� en sonda kal�yor
         * ---------------------------------------------------------------------------------------
         * 6. Resim alanlar�n� kaydet/g�ncelleme a�amas�nda nas�l bir yol izleyebiliriz? Hangi kontrol� kullanmal�
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