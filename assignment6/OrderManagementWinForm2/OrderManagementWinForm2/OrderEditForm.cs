using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement;
using OrderManagement.Services;
using OrderManagement.Models;

namespace OrderManagementWinForm2
{
    public partial class OrderEditForm : Form
    {
        private OrderService orderService;
        private Order currentOrder;
        private BindingSource bindingSourceOrderDetails = new BindingSource();
        public OrderEditForm(OrderService service, Order order = null)
        {
            InitializeComponent();
            orderService = service;
            currentOrder = order ?? new Order();
            if (currentOrder.OrderId != null)
            {
                textBoxOrderId.Text = currentOrder.OrderId;
                textBoxCustomer.Text = currentOrder.Customer;
                BindOrderDetailsToDataGridView();
            }
        }
        private void BindOrderDetailsToDataGridView()
        {
            bindingSourceOrderDetails.DataSource = currentOrder.Details;
            dataGridViewOrderDetails.DataSource = bindingSourceOrderDetails;
        }
        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
            string product = textBoxProduct.Text;
            decimal price;
            if(!decimal.TryParse(textBoxPrice.Text,out price))
            {
                MessageBox.Show("价格输入格式不正确，请输入有效数字");
                return;
            }
            int quantity;
            if(!int.TryParse(textBoxQuantity.Text,out quantity))
            {
                MessageBox.Show("数量输入格式不正确，请输入有效的数字");
                return;
            }
            OrderDetails newDetail = new OrderDetails
            {
                Product = product,
                Quantity = quantity,
                Price = price
            };
            currentOrder.Details.Add(newDetail);
            BindOrderDetailsToDataGridView();
        }
        private void dataGridViewOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDeleteDetails_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrderDetails.SelectedRows.Count > 0)
            {
                int index = dataGridViewOrderDetails.SelectedRows[0].Index;
                currentOrder.Details.RemoveAt(index);
                BindOrderDetailsToDataGridView();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            currentOrder.OrderId = textBoxOrderId.Text;
            currentOrder.Customer = textBoxCustomer.Text;
            try
            {
                if (string.IsNullOrEmpty(currentOrder.OrderId))
                {
                    orderService.AddOrder(currentOrder);
                }
                else
                {
                    orderService.UpdateOrder(currentOrder);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"操作失败：{ex.Message}");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
