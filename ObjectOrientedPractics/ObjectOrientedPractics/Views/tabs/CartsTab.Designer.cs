namespace ObjectOrientedPractices.Views.tabs
{
    partial class CartsTab
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

        private void InitializeComponent()
        {
            AddToCartButton = new Button();
            ItemsListBox = new ListBox();
            label1 = new Label();
            CustomerComboBox = new ComboBox();
            label5 = new Label();
            label2 = new Label();
            label4 = new Label();
            CreateOrderButton = new Button();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            CartListBox = new ListBox();
            AmountLabel = new Label();
            SuspendLayout();
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(4, 283);
            AddToCartButton.Margin = new Padding(4, 3, 4, 3);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(107, 44);
            AddToCartButton.TabIndex = 4;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(4, 24);
            ItemsListBox.Margin = new Padding(4, 3, 4, 3);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(269, 244);
            ItemsListBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(5, 6);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(37, 13);
            label1.TabIndex = 2;
            label1.Text = "Items";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(352, 20);
            CustomerComboBox.Margin = new Padding(4, 3, 4, 3);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(274, 23);
            CustomerComboBox.TabIndex = 16;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 70);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 14;
            label5.Text = "Cart:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(281, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 13);
            label2.TabIndex = 13;
            label2.Text = "Customer:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(564, 240);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 13);
            label4.TabIndex = 18;
            label4.Text = "Amount:";
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(288, 281);
            CreateOrderButton.Margin = new Padding(4, 3, 4, 3);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(107, 44);
            CreateOrderButton.TabIndex = 19;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(407, 281);
            RemoveItemButton.Margin = new Padding(4, 3, 4, 3);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(107, 44);
            RemoveItemButton.TabIndex = 20;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearCartButton.Location = new Point(519, 281);
            ClearCartButton.Margin = new Padding(4, 3, 4, 3);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(107, 44);
            ClearCartButton.TabIndex = 21;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(281, 88);
            CartListBox.Margin = new Padding(4, 3, 4, 3);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(345, 139);
            CartListBox.TabIndex = 22;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(564, 253);
            AmountLabel.Margin = new Padding(4, 0, 4, 0);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(45, 25);
            AmountLabel.TabIndex = 23;
            AmountLabel.Text = "0.0";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AmountLabel);
            Controls.Add(CartListBox);
            Controls.Add(ClearCartButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(CreateOrderButton);
            Controls.Add(label4);
            Controls.Add(CustomerComboBox);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(AddToCartButton);
            Controls.Add(ItemsListBox);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(630, 330);
            Name = "CartsTab";
            Size = new Size(630, 330);
            Load += CartsTab_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CustomerComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.ListBox CartListBox;
        private Label AmountLabel;
    }
}
