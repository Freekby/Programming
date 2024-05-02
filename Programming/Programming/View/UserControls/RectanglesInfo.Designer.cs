namespace Programming.View
{
    partial class RectanglesInfo
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
            RectanglesGroupBox = new GroupBox();
            label16 = new Label();
            RectangleIdTextBox = new TextBox();
            label15 = new Label();
            label14 = new Label();
            RectangleCenterYTextBox = new TextBox();
            RectangleCenterXTextBox = new TextBox();
            RectangleFindButton = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            RectagleLenghtTextBox = new TextBox();
            RectangleWidthTextBox = new TextBox();
            RectangleColorTextBox = new TextBox();
            RectanglesListBox = new ListBox();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(label16);
            RectanglesGroupBox.Controls.Add(RectangleIdTextBox);
            RectanglesGroupBox.Controls.Add(label15);
            RectanglesGroupBox.Controls.Add(label14);
            RectanglesGroupBox.Controls.Add(RectangleCenterYTextBox);
            RectanglesGroupBox.Controls.Add(RectangleCenterXTextBox);
            RectanglesGroupBox.Controls.Add(RectangleFindButton);
            RectanglesGroupBox.Controls.Add(label8);
            RectanglesGroupBox.Controls.Add(label7);
            RectanglesGroupBox.Controls.Add(label6);
            RectanglesGroupBox.Controls.Add(RectagleLenghtTextBox);
            RectanglesGroupBox.Controls.Add(RectangleWidthTextBox);
            RectanglesGroupBox.Controls.Add(RectangleColorTextBox);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Dock = DockStyle.Fill;
            RectanglesGroupBox.Location = new Point(0, 0);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(308, 273);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ImeMode = ImeMode.NoControl;
            label16.Location = new Point(238, 212);
            label16.Name = "label16";
            label16.Size = new Size(18, 15);
            label16.TabIndex = 13;
            label16.Text = "ID";
            // 
            // RectangleIdTextBox
            // 
            RectangleIdTextBox.Location = new Point(258, 209);
            RectangleIdTextBox.Name = "RectangleIdTextBox";
            RectangleIdTextBox.ReadOnly = true;
            RectangleIdTextBox.Size = new Size(44, 23);
            RectangleIdTextBox.TabIndex = 12;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ImeMode = ImeMode.NoControl;
            label15.Location = new Point(238, 183);
            label15.Name = "label15";
            label15.Size = new Size(14, 15);
            label15.TabIndex = 11;
            label15.Text = "Y";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ImeMode = ImeMode.NoControl;
            label14.Location = new Point(238, 154);
            label14.Name = "label14";
            label14.Size = new Size(14, 15);
            label14.TabIndex = 10;
            label14.Text = "X";
            // 
            // RectangleCenterYTextBox
            // 
            RectangleCenterYTextBox.Location = new Point(258, 180);
            RectangleCenterYTextBox.Name = "RectangleCenterYTextBox";
            RectangleCenterYTextBox.ReadOnly = true;
            RectangleCenterYTextBox.Size = new Size(44, 23);
            RectangleCenterYTextBox.TabIndex = 9;
            // 
            // RectangleCenterXTextBox
            // 
            RectangleCenterXTextBox.Location = new Point(258, 151);
            RectangleCenterXTextBox.Name = "RectangleCenterXTextBox";
            RectangleCenterXTextBox.ReadOnly = true;
            RectangleCenterXTextBox.Size = new Size(44, 23);
            RectangleCenterXTextBox.TabIndex = 8;
            // 
            // RectangleFindButton
            // 
            RectangleFindButton.ImeMode = ImeMode.NoControl;
            RectangleFindButton.Location = new Point(202, 243);
            RectangleFindButton.Name = "RectangleFindButton";
            RectangleFindButton.Size = new Size(100, 23);
            RectangleFindButton.TabIndex = 7;
            RectangleFindButton.Text = "Find";
            RectangleFindButton.UseVisualStyleBackColor = true;
            RectangleFindButton.Click += FindRectangleButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ImeMode = ImeMode.NoControl;
            label8.Location = new Point(202, 107);
            label8.Name = "label8";
            label8.Size = new Size(36, 15);
            label8.TabIndex = 6;
            label8.Text = "Color";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(202, 63);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 5;
            label7.Text = "Width";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(202, 22);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 4;
            label6.Text = "Lenght";
            // 
            // RectagleLenghtTextBox
            // 
            RectagleLenghtTextBox.Location = new Point(202, 40);
            RectagleLenghtTextBox.Name = "RectagleLenghtTextBox";
            RectagleLenghtTextBox.Size = new Size(100, 23);
            RectagleLenghtTextBox.TabIndex = 3;
            RectagleLenghtTextBox.TextChanged += RectangleLenghtTextBox_TextChanged;
            // 
            // RectangleWidthTextBox
            // 
            RectangleWidthTextBox.Location = new Point(202, 81);
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.Size = new Size(100, 23);
            RectangleWidthTextBox.TabIndex = 2;
            RectangleWidthTextBox.TextChanged += RectangleWidthTextBox_TextChanged;
            // 
            // RectangleColorTextBox
            // 
            RectangleColorTextBox.Location = new Point(202, 125);
            RectangleColorTextBox.Name = "RectangleColorTextBox";
            RectangleColorTextBox.Size = new Size(100, 23);
            RectangleColorTextBox.TabIndex = 1;
            RectangleColorTextBox.TextChanged += RectangleColorTextBox_TextChanged;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Items.AddRange(new object[] { "Rectagle1", "Rectagle2", "Rectagle3", "Rectagle4", "Rectagle5" });
            RectanglesListBox.Location = new Point(6, 22);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(190, 244);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            MinimumSize = new Size(308, 273);
            Name = "RectanglesInfo";
            Size = new Size(308, 273);
            Load += RectanglesInfo_Load;
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private Label label16;
        private TextBox RectangleIdTextBox;
        private Label label15;
        private Label label14;
        private TextBox RectangleCenterYTextBox;
        private TextBox RectangleCenterXTextBox;
        private Button RectangleFindButton;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox RectagleLenghtTextBox;
        private TextBox RectangleWidthTextBox;
        private TextBox RectangleColorTextBox;
        private ListBox RectanglesListBox;
    }
}
