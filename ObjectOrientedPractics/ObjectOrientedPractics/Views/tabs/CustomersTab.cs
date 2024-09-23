namespace ObjectOrientedPractices.Views.tabs
{
    public partial class CustomersTab : UserControl
    {
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// список для хранения всех покупателей
        /// </summary>
        private List<Customer> _customers = new();
        /// <summary>
        /// текущий выбранный покупатель
        /// </summary>
        private Customer _currentCustomer;
        /// <summary>
        /// true если данные введены в поля правильно, иначе - false
        /// </summary>
        bool _isDataCorrect = true;

        private void CostumersTab_Load(object sender, EventArgs e)
        {
            _customers.Add(CustumersGenerator.GetNextCustomer());
            _customers.Add(CustumersGenerator.GetNextCustomer());
            _customers.Add(CustumersGenerator.GetNextCustomer());
            _customers.Add(CustumersGenerator.GetNextCustomer());

            CustomersListBox.DataSource = _customers;
            CustomersListBox.SelectedIndex = 0;
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem is null) { return; }
            if (!_isDataCorrect)
            {
                CustomersListBox.SelectedItem = _currentCustomer;
                return;
            }

            _currentCustomer = CustomersListBox.SelectedItem as Customer;

            CustomerIDTextBox.Text = _currentCustomer.ID.ToString();
            CustomerAddressTextBox.Text = _currentCustomer.Address;
            CustomerNameTextBox.Text = _currentCustomer.FullName;

            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void CustomersListBox_Click(object sender, EventArgs e)
        {
            _isDataCorrect = true;

            CustomerAddressTextBox.BackColor = Color.White;
            CustomerNameTextBox.BackColor = Color.White;

            try
            {
                string newAddress = CustomerAddressTextBox.Text;
                _currentCustomer.Address = newAddress;
            }
            catch (Exception) 
            {
                _isDataCorrect = false;
                CustomerAddressTextBox.BackColor = Color.LightPink;
            }

            try
            {
                string newFullName = CustomerNameTextBox.Text;
                _currentCustomer.FullName = newFullName;
            }
            catch (Exception)
            {
                _isDataCorrect = false;
                CustomerNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddCostumerButton_Click(object sender, EventArgs e)
        {
            Customer newCustomer = CustumersGenerator.GetNextCustomer();
            _customers.Add(newCustomer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void RemoveCustumerButton_Click(object sender, EventArgs e)
        {
            _customers.Remove(_currentCustomer);
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

    }
}
