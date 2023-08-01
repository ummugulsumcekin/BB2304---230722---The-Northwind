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
    public partial class OrderCreateForm : Form
    {
        private readonly OrderRepository _orderRepository = new OrderRepository();
        private List<OrderDetailInputModel> _orderDetailsList = new List<OrderDetailInputModel>();

        public OrderCreateForm()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Dialog
            // Modal
            var orderDetailEditForm = new OrderDetailEditForm();

            // Event Listening
            orderDetailEditForm.OrderDetailCreated += OrderDetailCreatedMethod;

            // Gerektiği takdirde bir Event'e birden fazla Listener metod bağlanabilir
            //orderDetailEditForm.OrderDetailCreated += BirMethod;

            orderDetailEditForm.ShowDialog();
        }

        private void BirMethod(OrderDetail orderDetail)
        {

        }

        // Event Handling
        private void OrderDetailCreatedMethod(OrderDetailInputModel orderDetail)
        {
            // Benim bu metodum çalıştığında biliyorum ki diğer Form'da
            // OrderDetail nesnesi hazır hale geldi

            _orderDetailsList.Add(orderDetail);

            gridOrderDetails.DataSource = null;
            gridOrderDetails.DataSource = _orderDetailsList;
        }

        private void OrderCreateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Input
            // 1. Entity nesneyi oluştur
            var order = new Order();
            order.CustomerID = (string)cmbCustomer.SelectedValue;
            order.EmployeeID = (int?)cmbEmployee.SelectedValue;
            order.OrderDate = dtpOrderDate.Value;
            order.RequiredDate = dtpRequiredDate.Value;
            order.ShippedDate = dtpShippedDate.Value;
            order.ShipVia = (int?)cmbShipper.SelectedValue;
            order.Freight = numFreight.Value;
            order.ShipName = string.IsNullOrWhiteSpace(txtShipName.Text) ? null : txtShipName.Text;
            order.ShipCountry = txtShipCountry.Text;
            order.ShipCity = txtShipCity.Text;
            order.ShipAddress = txtShipAddress.Text;
            order.ShipRegion = txtShipRegion.Text;
            order.ShipPostalCode = txtShipPostalCode.Text;

            foreach (var detailInput in _orderDetailsList)
            {
                // Her adımda OrderDetailInputModel tipinde olan nesneyi
                // OrderDetail entity nesnesine MAPlemem lazım
                // ViewModel -> Entity
                var orderDetailEntity = new OrderDetail()
                {
                    ProductID = detailInput.ProductID,
                    UnitPrice = detailInput.UnitPrice,
                    Quantity = detailInput.Quantity,
                    Discount = detailInput.Discount
                };

                order.OrderDetails.Add(orderDetailEntity);
            }

            //order.OrderDetails.AddRange(_orderDetailsList);

            // 2. Nesneyi Repo'ya (Service, Manager, BLL) gönder
            // Spoiler! Projenizde Business katmanı olduğunda arayüz doğrudan
            // DataAccess'te yer alan OrderRepository sınıfına erişmeyecek
            // Business katmanında tahminen şu isimlerden biriyle isimlendirilmiş
            // {OrderService, OrderManager, OrderBusiness, OrderBLL (Business Logic Layer)}
            // nesneye bu order nesnesini göndereceksiniz

            var result = _orderRepository.Add(order);

            // 3. Sonucu değerlendir
            if (result)
            {
                MessageBox.Show("Sipariş başarıyla oluşturuldu");
            }
            else
            {
                MessageBox.Show("Sipariş oluşturulamadı");
            }
        }
    }
}
