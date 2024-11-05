namespace ObjectOrientedPractices.Views.tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private List<Item> _items;
        private PriorityOrder _order = new PriorityOrder();

        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        public PriorityOrdersTab()
        {
            InitializeComponent();
        }

        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {
            _order.Address = new Address(122122, "Russia", "Kiselburg", "EbaniUgol'", "50", "50");
            UpdateOrderInfo();
        }

        private void UpdateOrderItemsInfo()
        {
            OrderItemsListBox.DataSource = null;
            OrderItemsListBox.DataSource = _order.Items;
            AmountTextBox.Text = _order.Cost.ToString();
        }

        public void UpdateOrderInfo()
        {
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            DeliveryTimeComboBox.DataSource = PriorityOrder.RangesList;

            UpdateOrderItemsInfo();
            IdTextBox.Text = _order.Id.ToString();
            DateTextBox.Text = _order.Date.ToString();
            StatusComboBox.SelectedItem = _order.Status;
            DeliveryTimeComboBox.SelectedItem = _order.DeliveryTime;
            addressControl.Address = _order.Address;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedItem == null) { return; }
            _order.Items.Remove(OrderItemsListBox.SelectedItem as Item);
            UpdateOrderItemsInfo();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            _order.Items.Add(_items[1]);
            UpdateOrderItemsInfo();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _order = new PriorityOrder();
            UpdateOrderInfo();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.Status = (OrderStatus)StatusComboBox.SelectedItem;
            UpdateOrderItemsInfo();
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _order.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
            UpdateOrderItemsInfo();
        }
    }
}
