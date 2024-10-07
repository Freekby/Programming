using ObjectOrientedPractices.Views.tabs;

namespace ObjectOrientedPractices
{
    public partial class MainForm : Form
    {
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
            itemsTab1.Items = _store.Items;
        }

    }
}
