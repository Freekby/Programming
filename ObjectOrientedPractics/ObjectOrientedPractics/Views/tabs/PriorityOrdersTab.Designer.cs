using ObjectOrientedPractices.Models;

namespace ObjectOrientedPractices.Views.tabs
{
    partial class PriorityOrdersTab
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
            AmountTextBox = new TextBox();
            OrderItemsListBox = new ListBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            StatusComboBox = new ComboBox();
            DateTextBox = new TextBox();
            IdTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            DeliveryTimeComboBox = new ComboBox();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ClearOrderButton = new Button();
            addressControl = new Controls.AddressControl();
            SuspendLayout();
            // 
            // AmountTextBox
            // 
            AmountTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountTextBox.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AmountTextBox.Location = new Point(412, 477);
            AmountTextBox.Margin = new Padding(4, 3, 4, 3);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.ReadOnly = true;
            AmountTextBox.Size = new Size(126, 29);
            AmountTextBox.TabIndex = 38;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(14, 314);
            OrderItemsListBox.Margin = new Padding(4, 3, 4, 3);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(524, 139);
            OrderItemsListBox.TabIndex = 37;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(477, 458);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 13);
            label7.TabIndex = 36;
            label7.Text = "Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(10, 295);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 13);
            label6.TabIndex = 34;
            label6.Text = "Order Items";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 70);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 33;
            label5.Text = "Created:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 100);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 32;
            label4.Text = "Status:";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(79, 97);
            StatusComboBox.Margin = new Padding(4, 3, 4, 3);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(140, 23);
            StatusComboBox.TabIndex = 31;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // DateTextBox
            // 
            DateTextBox.Enabled = false;
            DateTextBox.Location = new Point(79, 67);
            DateTextBox.Margin = new Padding(4, 3, 4, 3);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.ReadOnly = true;
            DateTextBox.Size = new Size(140, 23);
            DateTextBox.TabIndex = 30;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(79, 37);
            IdTextBox.Margin = new Padding(4, 3, 4, 3);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(140, 23);
            IdTextBox.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 40);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 28;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(10, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 13);
            label2.TabIndex = 27;
            label2.Text = "Selected Order";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(266, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 13);
            label1.TabIndex = 39;
            label1.Text = "Priority Options:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 40);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 40;
            label8.Text = "Delivery Time:";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(359, 37);
            DeliveryTimeComboBox.Margin = new Padding(4, 3, 4, 3);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(140, 23);
            DeliveryTimeComboBox.TabIndex = 41;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(14, 517);
            AddItemButton.Margin = new Padding(4, 3, 4, 3);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(104, 40);
            AddItemButton.TabIndex = 42;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(125, 517);
            RemoveItemButton.Margin = new Padding(4, 3, 4, 3);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(104, 40);
            RemoveItemButton.TabIndex = 43;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearOrderButton.Location = new Point(435, 517);
            ClearOrderButton.Margin = new Padding(4, 3, 4, 3);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(104, 40);
            ClearOrderButton.TabIndex = 44;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // addressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            addressControl.Address = address1;
            addressControl.Enabled = false;
            addressControl.Location = new Point(14, 128);
            addressControl.Margin = new Padding(4, 3, 4, 3);
            addressControl.MinimumSize = new Size(642, 162);
            addressControl.Name = "addressControl";
            addressControl.Size = new Size(642, 164);
            addressControl.TabIndex = 35;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearOrderButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(AddItemButton);
            Controls.Add(DeliveryTimeComboBox);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(AmountTextBox);
            Controls.Add(OrderItemsListBox);
            Controls.Add(label7);
            Controls.Add(addressControl);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(StatusComboBox);
            Controls.Add(DateTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PriorityOrdersTab";
            Size = new Size(546, 590);
            Load += PriorityOrdersTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label label7;
        private Controls.AddressControl addressControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearOrderButton;
    }
}
