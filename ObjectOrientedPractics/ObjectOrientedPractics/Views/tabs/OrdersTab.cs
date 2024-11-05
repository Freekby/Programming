using System.Data;

namespace ObjectOrientedPractices.Views.tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = [];

        /// <summary>
        /// Возвращает и задаёт список всех покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
            }
        }

        public OrdersTab()
        {
            InitializeComponent();
        }

        private void OrdersTab_Load(object sender, EventArgs e)
        {
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            DeliveryTimeComboBox.DataSource = PriorityOrder.RangesList;
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            OrderItemsListBox.DataSource = null;
            if (OrdersDataGridView.SelectedCells.Count == 0)
            {
                IdTextBox.Text = string.Empty;
                DateTextBox.Text = string.Empty;
                StatusComboBox.Text = string.Empty;
                addressControl1.Address = new Address();
                AmountLabel.Text = string.Empty;
            }
            else
            {
                Order order = _orders[OrdersDataGridView.CurrentRow.Index];
                if (order is PriorityOrder priorityOrder)
                {
                    PriorityOptionsGroupBox.Visible = true;
                    DeliveryTimeComboBox.SelectedItem = priorityOrder.DeliveryTime;
                }
                else
                { 
                    PriorityOptionsGroupBox.Visible = false;
                }
                IdTextBox.Text = order.Id.ToString();
                DateTextBox.Text = order.Date.ToString();
                StatusComboBox.Text = order.Status.ToString();
                addressControl1.Address = order.Address;
                OrderItemsListBox.DataSource = order.Items;
                AmountLabel.Text = order.Cost.ToString();
            }
        }

        public void UpdateOrders()
        {
            _orders.Clear();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Address", typeof(string));
            dataTable.Columns.Add("Status", typeof(OrderStatus));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Amount", typeof(double));
            dataTable.Columns.Add("CustomerName", typeof(string));

            foreach (var customer in _customers)
            {
                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);

                    var row = dataTable.NewRow();
                    row["ID"] = order.Id;
                    row["Address"] = customer.Address.ToString();
                    row["Status"] = order.Status;
                    row["Date"] = order.Date;
                    row["Amount"] = order.Cost;
                    row["CustomerName"] = customer.FullName;
                    dataTable.Rows.Add(row);
                }
            }

            OrdersDataGridView.DataSource = dataTable;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentRow == null) { return; }
            Order order = _orders[OrdersDataGridView.CurrentRow.Index];
            order.Status = (OrderStatus)StatusComboBox.SelectedItem;
            OrdersDataGridView.CurrentRow.Cells[2].Value = order.Status;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentRow == null) { return; }

            if(_orders[OrdersDataGridView.CurrentRow.Index] is PriorityOrder priority)
            {
                priority.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
            }
        }
    }
}
