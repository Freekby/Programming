using ObjectOrientedPractices.Models;
using ObjectOrientedPractices.Models.Enums;
using ObjectOrientedPractices.Models.Orders;

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
            DiscountsCheckedListBox.DataSource = null;
            DiscountsCheckedListBox.DataSource = _currentCustomer.Discounts;


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

        private void DiscountsCheckedListBox_KeyUp(object sender, MouseEventArgs e)
        {
            UpdateCartData();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.Items.Count == 0) { return; }

            double discountAmount = 0;
            List<IDiscount> selectedDiscounts = new List<IDiscount>(); // Список выбранных скидок

            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                var discount = _currentCustomer.Discounts[index];
                discountAmount += discount.Apply(_currentCustomer.Cart.Items);
                selectedDiscounts.Add(discount); // Добавляем в список выбранных
            }

            if (_currentCustomer.IsPriority)
            {

                PriorityOrder newOrder = new PriorityOrder(DateTime.Now.AddDays(1), PriorityOrder.RangesList[0],
                    _currentCustomer.Address, _currentCustomer.Cart.Items, discountAmount);

                _currentCustomer.Orders.Add(newOrder);
            }
            else
            {
                Order newOrder = new Order(_currentCustomer.Address, _currentCustomer.Cart.Items, discountAmount);
                _currentCustomer.Orders.Add(newOrder);
            }

            foreach (var discount in _currentCustomer.Discounts)
            {
                discount.Update(_currentCustomer.Cart.Items);
            }

            DiscountsCheckedListBox.DataSource = null;
            DiscountsCheckedListBox.DataSource = _currentCustomer.Discounts;

            _currentCustomer.Cart.Clear();
            UpdateCartData();
        }

        /// <summary>
        /// Обновляет данные о товарах в корзине.
        /// </summary>
        private void UpdateCartData()
        {
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();

            double currentDiscount = CalculateDiscount();
            DiscountAmountLabel.Text = currentDiscount.ToString();

            double totalPrice = _currentCustomer.Cart.Amount - currentDiscount;
            TotalPriceLabel.Text = totalPrice.ToString();

            CartListBox.DataSource = null;
            CartListBox.DataSource = _currentCustomer.Cart.Items;
        }

        /// <summary>
        /// Высчитывает размер скидки
        /// </summary>
        /// <returns>Размер скидки</returns>
        private double CalculateDiscount()
        {
            double discountAmount = 0;
            foreach (int index in DiscountsCheckedListBox.CheckedIndices)
            {
                discountAmount += _currentCustomer.Discounts[index].Calculate(_currentCustomer.Cart.Items);
            }

            return discountAmount;
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
