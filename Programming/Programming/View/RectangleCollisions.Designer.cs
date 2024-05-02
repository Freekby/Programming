namespace Programming.View
{
    partial class RectangleCollisions
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
            RectangleColissionsGropBox = new GroupBox();
            DeleteRectangleButton = new Button();
            AddRectangleButton = new Button();
            RectangleHeightTextBox = new TextBox();
            RectangleWidthTextBox = new TextBox();
            RectangleCenterYTextBox = new TextBox();
            RectangleCenterXTextBox = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            RectanglesPanel = new Panel();
            RectangleIdTextBox = new TextBox();
            label19 = new Label();
            label18 = new Label();
            RectanglesListBox = new ListBox();
            label17 = new Label();
            RectangleColissionsGropBox.SuspendLayout();
            SuspendLayout();
            // 
            // RectangleColissionsGropBox
            // 
            RectangleColissionsGropBox.Controls.Add(DeleteRectangleButton);
            RectangleColissionsGropBox.Controls.Add(AddRectangleButton);
            RectangleColissionsGropBox.Controls.Add(RectangleHeightTextBox);
            RectangleColissionsGropBox.Controls.Add(RectangleWidthTextBox);
            RectangleColissionsGropBox.Controls.Add(RectangleCenterYTextBox);
            RectangleColissionsGropBox.Controls.Add(RectangleCenterXTextBox);
            RectangleColissionsGropBox.Controls.Add(label23);
            RectangleColissionsGropBox.Controls.Add(label22);
            RectangleColissionsGropBox.Controls.Add(label21);
            RectangleColissionsGropBox.Controls.Add(label20);
            RectangleColissionsGropBox.Controls.Add(RectanglesPanel);
            RectangleColissionsGropBox.Controls.Add(RectangleIdTextBox);
            RectangleColissionsGropBox.Controls.Add(label19);
            RectangleColissionsGropBox.Controls.Add(label18);
            RectangleColissionsGropBox.Controls.Add(RectanglesListBox);
            RectangleColissionsGropBox.Controls.Add(label17);
            RectangleColissionsGropBox.Dock = DockStyle.Fill;
            RectangleColissionsGropBox.Location = new Point(0, 0);
            RectangleColissionsGropBox.Name = "RectangleColissionsGropBox";
            RectangleColissionsGropBox.Size = new Size(450, 405);
            RectangleColissionsGropBox.TabIndex = 0;
            RectangleColissionsGropBox.TabStop = false;
            RectangleColissionsGropBox.Text = "Rectangle collision ";
            // 
            // DeleteRectangleButton
            // 
            DeleteRectangleButton.Location = new Point(87, 212);
            DeleteRectangleButton.Name = "DeleteRectangleButton";
            DeleteRectangleButton.Size = new Size(75, 23);
            DeleteRectangleButton.TabIndex = 31;
            DeleteRectangleButton.Text = "Delete";
            DeleteRectangleButton.UseVisualStyleBackColor = true;
            DeleteRectangleButton.Click += DeleteRectangleButton_Click;
            // 
            // AddRectangleButton
            // 
            AddRectangleButton.Location = new Point(6, 212);
            AddRectangleButton.Name = "AddRectangleButton";
            AddRectangleButton.Size = new Size(75, 23);
            AddRectangleButton.TabIndex = 30;
            AddRectangleButton.Text = "Add";
            AddRectangleButton.UseVisualStyleBackColor = true;
            AddRectangleButton.Click += AddRectangleButton_Click;
            // 
            // RectangleHeightTextBox
            // 
            RectangleHeightTextBox.Location = new Point(62, 373);
            RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            RectangleHeightTextBox.Size = new Size(100, 23);
            RectangleHeightTextBox.TabIndex = 29;
            RectangleHeightTextBox.TextChanged += RectangleHeightTextBox_TextChanged;
            // 
            // RectangleWidthTextBox
            // 
            RectangleWidthTextBox.Location = new Point(62, 344);
            RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            RectangleWidthTextBox.Size = new Size(100, 23);
            RectangleWidthTextBox.TabIndex = 28;
            RectangleWidthTextBox.TextChanged += RectangleWidthTextBox_TextChanged;
            // 
            // RectangleCenterYTextBox
            // 
            RectangleCenterYTextBox.Location = new Point(62, 315);
            RectangleCenterYTextBox.Name = "RectangleCenterYTextBox";
            RectangleCenterYTextBox.Size = new Size(100, 23);
            RectangleCenterYTextBox.TabIndex = 27;
            RectangleCenterYTextBox.TextChanged += RectanglesCenterYTextBox_TextChanged;
            // 
            // RectangleCenterXTextBox
            // 
            RectangleCenterXTextBox.Location = new Point(62, 286);
            RectangleCenterXTextBox.Name = "RectangleCenterXTextBox";
            RectangleCenterXTextBox.Size = new Size(100, 23);
            RectangleCenterXTextBox.TabIndex = 26;
            RectangleCenterXTextBox.TextChanged += RectangleCenterXTextBox_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(10, 381);
            label23.Name = "label23";
            label23.Size = new Size(46, 15);
            label23.TabIndex = 25;
            label23.Text = "Heigth:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(14, 352);
            label22.Name = "label22";
            label22.Size = new Size(42, 15);
            label22.TabIndex = 24;
            label22.Text = "Width:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(39, 323);
            label21.Name = "label21";
            label21.Size = new Size(17, 15);
            label21.TabIndex = 23;
            label21.Text = "Y:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(39, 294);
            label20.Name = "label20";
            label20.Size = new Size(17, 15);
            label20.TabIndex = 22;
            label20.Text = "X:";
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            RectanglesPanel.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Location = new Point(168, 19);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(276, 380);
            RectanglesPanel.TabIndex = 21;
            // 
            // RectangleIdTextBox
            // 
            RectangleIdTextBox.Location = new Point(62, 257);
            RectangleIdTextBox.Name = "RectangleIdTextBox";
            RectangleIdTextBox.ReadOnly = true;
            RectangleIdTextBox.Size = new Size(100, 23);
            RectangleIdTextBox.TabIndex = 20;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(36, 265);
            label19.Name = "label19";
            label19.Size = new Size(20, 15);
            label19.TabIndex = 19;
            label19.Text = "Id:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(6, 239);
            label18.Name = "label18";
            label18.Size = new Size(109, 15);
            label18.TabIndex = 18;
            label18.Text = "Selected Rectangle:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Location = new Point(6, 37);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(156, 169);
            RectanglesListBox.TabIndex = 17;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 19);
            label17.Name = "label17";
            label17.Size = new Size(67, 15);
            label17.TabIndex = 16;
            label17.Text = "Rectangles:";
            // 
            // RectangleCollisions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectangleColissionsGropBox);
            MinimumSize = new Size(450, 405);
            Name = "RectangleCollisions";
            Size = new Size(450, 405);
            RectangleColissionsGropBox.ResumeLayout(false);
            RectangleColissionsGropBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectangleColissionsGropBox;
        private Button DeleteRectangleButton;
        private Button AddRectangleButton;
        private TextBox RectangleHeightTextBox;
        private TextBox RectangleWidthTextBox;
        private TextBox RectangleCenterYTextBox;
        private TextBox RectangleCenterXTextBox;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private Panel RectanglesPanel;
        private TextBox RectangleIdTextBox;
        private Label label19;
        private Label label18;
        private ListBox RectanglesListBox;
        private Label label17;
    }
}
