using ObjectOrientedPractices.Models.Enums;
using ObjectOrientedPractices.Services;

namespace ObjectOrientedPractices.Views.tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// список для хранения всех товаров
        /// </summary>
        private List<Item> _items = new();
        /// <summary>
        /// отфильтрованый список всех товаров
        /// </summary>
        private List<Item> _filteredItems;
        /// <summary>
        /// текущий выбранный товар
        /// </summary>
        private Item _currentItem;

        private bool isNameChanged = false;

        public List<Item> Items
        {
            get { return _items; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Items не должно быть null");
                }
                _items = value;
            }
        }

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            _filteredItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));

            ItemCategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            SortComboBox.SelectedIndex = 0;
            ItemsListBox.DataSource = _filteredItems;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem is null) { return; }

            if (isNameChanged)
            {
                FilterItems();
                isNameChanged = false;
            }

            _currentItem = ItemsListBox.SelectedItem as Item;

            ItemIDTextBox.Text = _currentItem.Id.ToString();
            ItemCostTextBox.Text = _currentItem.Cost.ToString();
            ItemNameTextBox.Text = _currentItem.Name;
            ItemDescriptionTextBox.Text = _currentItem.Info;
            ItemCategoryComboBox.SelectedItem = _currentItem.Category;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item newItem = ItemGenerator.GetNextItem();
            _items.Add(newItem);
            _filteredItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));
            FilterItems();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            _items.Remove(_currentItem);
            _filteredItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));

            UpdateListBoxData();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            _filteredItems = DataTools.Filter(_items, item => item.Name.Contains(SearchTextBox.Text));
            UpdateListBoxData();
        }

        private void ItemNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ItemNameTextBox.BackColor = Color.White;
            try
            {
                string name = ItemNameTextBox.Text;
                if (name != _currentItem.Name) 
                { 
                    isNameChanged = true;
                }
                _currentItem.Name = name;
            }
            catch (Exception)
            {
                ItemNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void ItemCostTextBox_TextChanged(object sender, EventArgs e)
        {
            ItemCostTextBox.BackColor = Color.White;
            try
            {
                float cost = float.Parse(ItemCostTextBox.Text);
                _currentItem.Cost = cost;
            }
            catch (Exception)
            {
                ItemCostTextBox.BackColor = Color.LightPink;
            }
        }

        private void ItemCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem is null) { return; }
            _currentItem.Category = (Category)ItemCategoryComboBox.SelectedItem;
        }

        private void ItemDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            ItemDescriptionTextBox.BackColor = Color.White;
            try
            {
                string info = ItemDescriptionTextBox.Text;
                _currentItem.Info = info;
            }
            catch (Exception)
            {
                ItemDescriptionTextBox.BackColor = Color.LightPink;
            }
        }

        void UpdateListBoxData()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _filteredItems;
        }

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterItems();
        }

        void FilterItems()
        {
            if (_items == null) return;

            string searchText = SearchTextBox.Text;
            string selectedOrder = SortComboBox.SelectedItem.ToString();

            _filteredItems = DataTools.Filter(_items, item =>
                 item.Name.Contains(searchText)
                 );
            switch (selectedOrder)
            {
                case "Name":
                    _filteredItems = DataTools.Sort(_filteredItems, DataTools.CompareByName);

                    break;
                case "Cost (Ascending)":

                    _filteredItems = DataTools.Sort(_filteredItems, DataTools.CompareByCostAscending);

                    break;
                case "Cost (Descending)":

                    _filteredItems = DataTools.Sort(_filteredItems, DataTools.CompareByCostDescending);

                    break;
            }

            UpdateListBoxData();
        }
    }
}
