using OrderManagement;
using OrderManagement.Services;
using OrderManagement.Models;
using System.Drawing.Text;
namespace OrderManagementWinForm2
{
    public partial class Form1 : Form
    {
        private OrderService orderService = new OrderService();
        private BindingSource bindingSourceOrders = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }
        private void BindOrdersToDataGridView()
        {
            bindingSourceOrders.DataSource = orderService.orders;
            dataGridViewOrders.DataSource = bindingSourceOrders;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            BindOrdersToDataGridView();
            OrderEditForm orderEditForm = new OrderEditForm(orderService);
            DataGridView dataGridViewOrderDetails = orderEditForm.dataGridViewOrderDetails;
            bindingSourceOrders.CurrentChanged += (s, args) =>
            {
                var currentOrder = (Order)bindingSourceOrders.Current;
                if(currentOrder!=null)
                {
                    var bindingSourceDetails = new BindingSource();
                    bindingSourceDetails.DataSource = currentOrder.Details;
                    dataGridViewOrderDetails.DataSource = bindingSourceDetails;
                }
            };
        }
        private void buttonQueryOrder_Click(object sender, EventArgs e)
        {
            string queryValue = textBoxQuery.Text;
            string queryType = comboBoxQueryType.Text;
            List<Order> queriedOrders;
            switch (queryType)
            {
                case "������ID":
                    queriedOrders = orderService.QueryOrdersByOrderId(queryValue);
                    break;
                case "���ͻ�":
                    queriedOrders = orderService.QueryOrdersByCustomer(queryValue);
                    break;
                case "����Ʒ":
                    queriedOrders = orderService.QueryOrdersByProduct(queryValue);
                    break;
                default:
                    queriedOrders = new List<Order>();
                    break;
            }
            bindingSourceOrders.DataSource = queriedOrders;
            dataGridViewOrders.DataSource = bindingSourceOrders;
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            var editForm = new OrderEditForm(orderService);
            editForm.ShowDialog();
            BindOrdersToDataGridView();
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                var selectedOrder = (Order)dataGridViewOrders.SelectedRows[0].DataBoundItem;
                var editForm = new OrderEditForm(orderService, selectedOrder);
                editForm.ShowDialog();
                BindOrdersToDataGridView();
            }
            else
            {
                MessageBox.Show("����ѡ��Ҫ�޸ĵĶ���");
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if(dataGridViewOrders.SelectedRows.Count > 0)
            {
                var selectedOrders = (Order)dataGridViewOrders.SelectedRows[0].DataBoundItem;
                try
                {
                    orderService.DeleteOrder(selectedOrders.OrderId);
                    BindOrdersToDataGridView();
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"ɾ������ʧ�ܣ�{ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("����ѡ��Ҫɾ���Ķ���");
            }
        }

    }
}
