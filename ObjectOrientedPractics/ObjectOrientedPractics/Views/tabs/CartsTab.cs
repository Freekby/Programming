namespace ObjectOrientedPractices.Views.tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список всех товаров.
        /// </summary>
        private List<Item> _items;
        /// <summary>
        /// Список  всех покупателей.
        /// </summary>
        private List<Customer> _customers;
        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Возвращает и задаёт список всех товаров.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задаёт список всех покупателей
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public CartsTab()
        {
            InitializeComponent();
        }

        private void CartsTab_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = CustomerComboBox.SelectedItem as Customer;
            if (_currentCustomer is null) { return; }
            UpdateCartData();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = ItemsListBox.SelectedItem as Item;
            if (selectedItem is null || _currentCustomer is null) { return; }
            _currentCustomer.Cart.AddItem(selectedItem);

            UpdateCartData();
        }


        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = CartListBox.SelectedItem as Item;
            if (selectedItem is null) { return; }

            _currentCustomer.Cart.RemoveItem(selectedItem);

            UpdateCartData();
        }


        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer is null) { return; }
            _currentCustomer.Cart.Items.Clear();

            UpdateCartData();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count == 0) { return; }
            Order newOrder = new Order(_currentCustomer.Address, _currentCustomer.Cart.Items, _currentCustomer.Cart.Amount);
            _currentCustomer.Orders.Add(newOrder);

            _currentCustomer.Cart.Clear();
            UpdateCartData();
        }

        /// <summary>
        /// Обновляет данные о товарах в корзине.
        /// </summary>
        private void UpdateCartData()
        {
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();

            CartListBox.DataSource = null;
            CartListBox.DataSource = _currentCustomer.Cart.Items;
        }

        /// <summary>
        /// Обновляет данные о товарах и покупателях
        /// </summary>
        public void RefreshData()
        {
            CustomerComboBox.DataSource = null;
            ItemsListBox.DataSource = null;

            CustomerComboBox.DataSource = Customers;
            ItemsListBox.DataSource = Items;
        }

    }
}
