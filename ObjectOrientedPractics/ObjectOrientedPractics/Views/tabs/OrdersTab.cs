﻿namespace ObjectOrientedPractices.Views.tabs
{
    public partial class OrdersTab : UserControl
    {
        private List<Customer> _customers;

        private List<OrderData> _orderDatas = new List<OrderData>();

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
            UpdateOrders();
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
                OrderData order = _orderDatas[OrdersDataGridView.CurrentRow.Index];
                IdTextBox.Text = order.Id;
                DateTextBox.Text = order.Date;
                StatusComboBox.Text = order.Status;
                addressControl1.Address = order.Address;
                OrderItemsListBox.DataSource = order.Order.Items;
                AmountLabel.Text = order.Amount;
            }
        }

        public void UpdateOrders()
        {
            OrderDataBindingSource.Clear();
            OrdersDataGridView.DataSource = null;
            _orderDatas.Clear();
            foreach (var customer in Customers)
            {
                if(customer.Orders.Count == 0) { continue; }
                foreach (var order in customer.Orders)
                {
                    OrderData orderData = new OrderData();
                    orderData.Id = order.Id.ToString();
                    orderData.Address = order.Address;
                    orderData.Status = order.Status.ToString();
                    orderData.Date = order.Date.ToString();
                    orderData.Amount = $"{order.Cost}";
                    orderData.FullName = customer.FullName;
                    orderData.Order = order;

                    _orderDatas.Add(orderData);
                    OrderDataBindingSource.Add(orderData);
                }
            }
            OrdersDataGridView.DataSource = OrderDataBindingSource;
        }
    }
}
