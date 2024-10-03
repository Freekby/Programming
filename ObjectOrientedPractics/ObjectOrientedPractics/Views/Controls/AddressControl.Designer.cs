namespace ObjectOrientedPractices.Views.Controls
{
    partial class AddressControl
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            PostIndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            CityTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            StreetTextBox = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Post index:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 84);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Street:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 54);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Country:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(298, 54);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "City:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(197, 112);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Apartment:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 113);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 5;
            label6.Text = "Building:";
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(76, 22);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(132, 23);
            PostIndexTextBox.TabIndex = 6;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(76, 51);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(211, 23);
            CountryTextBox.TabIndex = 7;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(270, 109);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(115, 23);
            ApartmentTextBox.TabIndex = 8;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(335, 51);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(211, 23);
            CityTextBox.TabIndex = 9;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(77, 109);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(115, 23);
            BuildingTextBox.TabIndex = 10;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(77, 80);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(469, 23);
            StreetTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CityTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(StreetTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(PostIndexTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(BuildingTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(CountryTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(ApartmentTextBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(550, 140);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delivery adress";
            // 
            // AdressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            MinimumSize = new Size(550, 140);
            Name = "AdressControl";
            Size = new Size(550, 140);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
        private TextBox ApartmentTextBox;
        private TextBox CityTextBox;
        private TextBox BuildingTextBox;
        private TextBox StreetTextBox;
        private GroupBox groupBox1;
    }
}
