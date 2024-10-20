namespace ObjectOrientedPractices
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTabControl = new TabControl();
            ItemsTabPage = new TabPage();
            itemsTab = new Views.tabs.ItemsTab();
            CostumersTabPage = new TabPage();
            customersTab = new Views.tabs.CustomersTab();
            CartsTabPage = new TabPage();
            cartsTab = new Views.tabs.CartsTab();
            OrdersTabPage = new TabPage();
            ordersTab1 = new Views.tabs.OrdersTab();
            MainTabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CostumersTabPage.SuspendLayout();
            CartsTabPage.SuspendLayout();
            OrdersTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsTabPage);
            MainTabControl.Controls.Add(CostumersTabPage);
            MainTabControl.Controls.Add(CartsTabPage);
            MainTabControl.Controls.Add(OrdersTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(1060, 591);
            MainTabControl.TabIndex = 0;
            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(itemsTab);
            ItemsTabPage.Location = new Point(4, 24);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(898, 403);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            itemsTab.AutoSize = true;
            itemsTab.Dock = DockStyle.Fill;
            itemsTab.Location = new Point(3, 3);
            itemsTab.MinimumSize = new Size(570, 333);
            itemsTab.Name = "itemsTab";
            itemsTab.Size = new Size(892, 397);
            itemsTab.TabIndex = 0;
            // 
            // CostumersTabPage
            // 
            CostumersTabPage.Controls.Add(customersTab);
            CostumersTabPage.Location = new Point(4, 24);
            CostumersTabPage.Name = "CostumersTabPage";
            CostumersTabPage.Padding = new Padding(3);
            CostumersTabPage.Size = new Size(898, 403);
            CostumersTabPage.TabIndex = 1;
            CostumersTabPage.Text = "Costumers";
            CostumersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            customersTab.Dock = DockStyle.Fill;
            customersTab.Location = new Point(3, 3);
            customersTab.MinimumSize = new Size(815, 300);
            customersTab.Name = "customersTab";
            customersTab.Size = new Size(892, 397);
            customersTab.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(cartsTab);
            CartsTabPage.Location = new Point(4, 24);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Padding = new Padding(3);
            CartsTabPage.Size = new Size(898, 403);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "Cart";
            CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab
            // 
            cartsTab.Customers = null;
            cartsTab.Dock = DockStyle.Fill;
            cartsTab.Items = null;
            cartsTab.Location = new Point(3, 3);
            cartsTab.Margin = new Padding(4, 3, 4, 3);
            cartsTab.MinimumSize = new Size(630, 330);
            cartsTab.Name = "cartsTab";
            cartsTab.Size = new Size(892, 397);
            cartsTab.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(ordersTab1);
            OrdersTabPage.Location = new Point(4, 24);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Padding = new Padding(3);
            OrdersTabPage.Size = new Size(1052, 563);
            OrdersTabPage.TabIndex = 3;
            OrdersTabPage.Text = "Orders";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(3, 3);
            ordersTab1.Margin = new Padding(4, 3, 4, 3);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(1046, 557);
            ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 591);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            Text = "Object Oriented Practices";
            MainTabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            ItemsTabPage.PerformLayout();
            CostumersTabPage.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            OrdersTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ItemsTabPage;
        private Views.tabs.ItemsTab itemsTab;
        private TabPage CostumersTabPage;
        private Views.tabs.CustomersTab customersTab;
        private TabPage CartsTabPage;
        private Views.tabs.CartsTab cartsTab;
        private TabPage OrdersTabPage;
        private Views.tabs.OrdersTab ordersTab1;
    }
}
