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
using NorthwindProject.WinForms.ViewModels;

namespace NorthwindProject.WinForms
{
    public partial class OrderDetailEditForm : Form
    {
        private readonly ProductRepository _productRepository = new ProductRepository();

        public OrderDetailEditForm()
        {
            InitializeComponent();
        }

        // Delegate: Vekil, temsilci
        public delegate void OrderDetailCreatedHandler(OrderDetailInputModel orderDetail);

        public event OrderDetailCreatedHandler OrderDetailCreated;

        private void OrderDetailEditForm_Load(object sender, EventArgs e)
        {
            var allProducts = _productRepository.GetAll();
            cmbProduct.DataSource = allProducts;
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbProduct.SelectedItem != null)
            if (cmbProduct.SelectedIndex > -1)
            {
                var product = (Product)cmbProduct.SelectedItem;

                // 15.350000
                // 15.35
                txtUnitPrice.Text = product.UnitPrice?.ToString("N2");
            }
            else
            {
                txtUnitPrice.Text = string.Empty;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var orderDetailInput = new OrderDetailInputModel();
            orderDetailInput.ProductID = (int)cmbProduct.SelectedValue;
            orderDetailInput.ProductName = cmbProduct.Text;

            if (decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
                orderDetailInput.UnitPrice = unitPrice;

            orderDetailInput.Quantity = (short)numQuantity.Value;
            orderDetailInput.Discount = (float)numDiscount.Value / 100;

            // Event Fire (Olayı Fırlatmak)

            // Aşağıdaki şekilde çağırmak/fırlatmak riskli, eğer Event'i dinleyen kimse
            // yoksa NullReferenceException hatası alırıs
            //OrderDetailCreated(orderDetail);

            // Güvenli şekilde aşağıdaki gibi çağırabiliriz
            //if (OrderDetailCreated != null)
            //{
            //    OrderDetailCreated(orderDetail);
            //}

            // Ya da hem güvenli hem de kısa yazım şekliyle aşağıdaki
            // sentaks uygundur
            OrderDetailCreated?.Invoke(orderDetailInput);
        }

        private void cmbProduct_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
