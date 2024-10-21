namespace ObjectOrientedPractices
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();

            _store.Items.Add(ItemGenerator.GetNextItem());
            _store.Items.Add(ItemGenerator.GetNextItem());
            _store.Items.Add(ItemGenerator.GetNextItem());
            _store.Items.Add(ItemGenerator.GetNextItem());

            _store.Customers.Add(CustomersGenerator.GetNextCustomer());
            _store.Customers.Add(CustomersGenerator.GetNextCustomer());
            _store.Customers.Add(CustomersGenerator.GetNextCustomer());
            _store.Customers.Add(CustomersGenerator.GetNextCustomer());

            customersTab.Customers = _store.Customers;
            cartsTab.Customers = _store.Customers;
            ordersTab1.Customers = _store.Customers;

            itemsTab.Items = _store.Items;
            cartsTab.Items = _store.Items;
        }

        private void MainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MainTabControl.SelectedIndex)
            {
                case 2:
                    cartsTab.RefreshData();
                    break;
                case 3:
                    ordersTab1.UpdateOrders();
                    break;
            }
        }
    }
}
