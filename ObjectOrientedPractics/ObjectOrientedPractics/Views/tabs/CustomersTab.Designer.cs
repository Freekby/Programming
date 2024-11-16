using ObjectOrientedPractices.Models;

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
            Address address1 = new Address();
            CustomersGroupBox = new GroupBox();
            RemoveCustumerButton = new Button();
            AddCustumerButton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            CustomersDiscountsGroupBox = new GroupBox();
            CustomersDiscountsListBox = new ListBox();
            AddDiscountButton = new Button();
            RemoveDiscountButton = new Button();
            PriorityCheckBox = new CheckBox();
            CustomerAdressControl = new Controls.AddressControl();
            CustomerNameTextBox = new TextBox();
            CustomerIDTextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            CustomersDiscountsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersGroupBox.Controls.Add(RemoveCustumerButton);
            CustomersGroupBox.Controls.Add(AddCustumerButton);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Location = new Point(0, 0);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(255, 528);
            CustomersGroupBox.TabIndex = 1;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // RemoveCustumerButton
            // 
            RemoveCustumerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveCustumerButton.Location = new Point(126, 488);
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
            AddCustumerButton.Location = new Point(6, 488);
            AddCustumerButton.Name = "AddCustumerButton";
            AddCustumerButton.Size = new Size(114, 34);
            AddCustumerButton.TabIndex = 1;
            AddCustumerButton.Text = "Add Customer";
            AddCustumerButton.UseVisualStyleBackColor = true;
            AddCustumerButton.Click += AddCostumerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 19);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(243, 409);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.Click += CustomersListBox_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(CustomersDiscountsGroupBox);
            SelectedCustomerGroupBox.Controls.Add(PriorityCheckBox);
            SelectedCustomerGroupBox.Controls.Add(CustomerAdressControl);
            SelectedCustomerGroupBox.Controls.Add(CustomerNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(CustomerIDTextBox);
            SelectedCustomerGroupBox.Controls.Add(label3);
            SelectedCustomerGroupBox.Controls.Add(label1);
            SelectedCustomerGroupBox.Location = new Point(255, 0);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(557, 522);
            SelectedCustomerGroupBox.TabIndex = 2;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected customer";
            // 
            // CustomersDiscountsGroupBox
            // 
            CustomersDiscountsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersDiscountsGroupBox.Controls.Add(CustomersDiscountsListBox);
            CustomersDiscountsGroupBox.Controls.Add(AddDiscountButton);
            CustomersDiscountsGroupBox.Controls.Add(RemoveDiscountButton);
            CustomersDiscountsGroupBox.Location = new Point(6, 309);
            CustomersDiscountsGroupBox.Name = "CustomersDiscountsGroupBox";
            CustomersDiscountsGroupBox.Size = new Size(370, 119);
            CustomersDiscountsGroupBox.TabIndex = 3;
            CustomersDiscountsGroupBox.TabStop = false;
            CustomersDiscountsGroupBox.Text = "Discounts";
            // 
            // CustomersDiscountsListBox
            // 
            CustomersDiscountsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersDiscountsListBox.FormattingEnabled = true;
            CustomersDiscountsListBox.ItemHeight = 15;
            CustomersDiscountsListBox.Location = new Point(6, 18);
            CustomersDiscountsListBox.Name = "CustomersDiscountsListBox";
            CustomersDiscountsListBox.Size = new Size(248, 94);
            CustomersDiscountsListBox.TabIndex = 3;
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AddDiscountButton.Location = new Point(271, 22);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(93, 42);
            AddDiscountButton.TabIndex = 2;
            AddDiscountButton.Text = "Add";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveDiscountButton.Location = new Point(271, 71);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Size = new Size(93, 42);
            RemoveDiscountButton.TabIndex = 1;
            RemoveDiscountButton.Text = "Remove";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // PriorityCheckBox
            // 
            PriorityCheckBox.AutoSize = true;
            PriorityCheckBox.Location = new Point(156, 22);
            PriorityCheckBox.Name = "PriorityCheckBox";
            PriorityCheckBox.Size = new Size(75, 19);
            PriorityCheckBox.TabIndex = 7;
            PriorityCheckBox.Text = "Is priority";
            PriorityCheckBox.UseVisualStyleBackColor = true;
            PriorityCheckBox.CheckedChanged += PriorityCheckBox_CheckedChanged;
            // 
            // CustomerAdressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            CustomerAdressControl.Address = address1;
            CustomerAdressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            CustomerNameTextBox.Size = new Size(545, 86);
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
            MinimumSize = new Size(815, 300);
            Name = "CustomersTab";
            Size = new Size(815, 528);
            Load += CostumersTab_Load;
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            CustomersDiscountsGroupBox.ResumeLayout(false);
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
        private CheckBox PriorityCheckBox;
        private GroupBox CustomersDiscountsGroupBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button AddDiscountButton;
        private Button RemoveDiscountButton;
        private ListBox CustomersDiscountsListBox;
    }
}
