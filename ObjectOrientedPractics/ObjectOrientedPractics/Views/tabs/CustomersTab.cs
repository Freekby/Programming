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
        private bool _isDataCorrect = true;

        public List<Customer> Customers
        {
            get { return _customers; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customers не должно быть null");
                }
                _customers = value;
            }
        }

        private void CostumersTab_Load(object sender, EventArgs e)
        {
            CustomersListBox.DataSource = _customers;
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
            CustomerNameTextBox.Text = _currentCustomer.FullName;
            CustomerAdressControl.Address = _currentCustomer.Address;


            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
        }

        private void CustomersListBox_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem  == null) {return;}

            _isDataCorrect = true;

            CustomerNameTextBox.BackColor = Color.White;

            if (CustomerAdressControl.TryWriteAdressData())
            {
                _currentCustomer.Address = CustomerAdressControl.Address;
            }
            else
            {
                _isDataCorrect = false;
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
            Customer newCustomer = CustomersGenerator.GetNextCustomer();
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
