namespace ObjectOrientedPractices.Views.tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            //Address address2 = new Address();
            CustomersGroupBox = new GroupBox();
            RemoveCustumerButton = new Button();
            AddCustumerButton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            CustomerAdressControl = new Controls.AddressControl();
            CustomerNameTextBox = new TextBox();
            CustomerIDTextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersGroupBox.Controls.Add(RemoveCustumerButton);
            CustomersGroupBox.Controls.Add(AddCustumerButton);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Location = new Point(0, 0);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(246, 304);
            CustomersGroupBox.TabIndex = 1;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // RemoveCustumerButton
            // 
            RemoveCustumerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveCustumerButton.Location = new Point(126, 264);
            RemoveCustumerButton.Name = "RemoveCustumerButton";
            RemoveCustumerButton.Size = new Size(114, 34);
            RemoveCustumerButton.TabIndex = 2;
            RemoveCustumerButton.Text = "Remove Customer";
            RemoveCustumerButton.UseVisualStyleBackColor = true;
            RemoveCustumerButton.Click += RemoveCustumerButton_Click;
            // 
            // AddCustumerButton
            // 
            AddCustumerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCustumerButton.Location = new Point(6, 264);
            AddCustumerButton.Name = "AddCustumerButton";
            AddCustumerButton.Size = new Size(114, 34);
            AddCustumerButton.TabIndex = 1;
            AddCustumerButton.Text = "Add Customer";
            AddCustumerButton.UseVisualStyleBackColor = true;
            AddCustumerButton.Click += AddCostumerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 19);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(234, 199);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.Click += CustomersListBox_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(CustomerAdressControl);
            SelectedCustomerGroupBox.Controls.Add(CustomerNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(CustomerIDTextBox);
            SelectedCustomerGroupBox.Controls.Add(label3);
            SelectedCustomerGroupBox.Controls.Add(label1);
            SelectedCustomerGroupBox.Location = new Point(252, 0);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(558, 304);
            SelectedCustomerGroupBox.TabIndex = 2;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected customer";
            // 
            // CustomerAdressControl
            // 
            //address2.Apartment = null;
            //address2.Building = null;
            //address2.City = null;
            //address2.Country = null;
            //address2.Index = 0;
            //address2.Street = null;
            //CustomerAdressControl.Address = address2;
            CustomerAdressControl.Location = new Point(6, 163);
            CustomerAdressControl.MinimumSize = new Size(550, 140);
            CustomerAdressControl.Name = "CustomerAdressControl";
            CustomerAdressControl.Size = new Size(550, 140);
            CustomerAdressControl.TabIndex = 3;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerNameTextBox.Location = new Point(6, 71);
            CustomerNameTextBox.Multiline = true;
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(546, 86);
            CustomerNameTextBox.TabIndex = 6;
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(50, 16);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.ReadOnly = true;
            CustomerIDTextBox.Size = new Size(100, 23);
            CustomerIDTextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 53);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomersGroupBox);
            MinimumSize = new Size(570, 300);
            Name = "CustomersTab";
            Size = new Size(813, 304);
            Load += CostumersTab_Load;
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersGroupBox;
        private Button RemoveCustumerButton;
        private Button AddCustumerButton;
        private ListBox CustomersListBox;
        private GroupBox SelectedCustomerGroupBox;
        private TextBox CustomerNameTextBox;
        private TextBox CustomerIDTextBox;
        private Label label3;
        private Label label1;
        private Controls.AddressControl CustomerAdressControl;
    }
}
