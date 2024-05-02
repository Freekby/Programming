namespace Programming.View
{
    partial class WeekdayParsing
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
            WeekdayGroupBox = new GroupBox();
            WeekdayTextBox = new TextBox();
            WeekdayParsingButton = new Button();
            ParsedWeekdayLabel = new Label();
            label4 = new Label();
            WeekdayGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // WeekdayGroupBox
            // 
            WeekdayGroupBox.Controls.Add(WeekdayTextBox);
            WeekdayGroupBox.Controls.Add(WeekdayParsingButton);
            WeekdayGroupBox.Controls.Add(ParsedWeekdayLabel);
            WeekdayGroupBox.Controls.Add(label4);
            WeekdayGroupBox.Dock = DockStyle.Fill;
            WeekdayGroupBox.Location = new Point(0, 0);
            WeekdayGroupBox.Name = "WeekdayGroupBox";
            WeekdayGroupBox.Size = new Size(230, 90);
            WeekdayGroupBox.TabIndex = 8;
            WeekdayGroupBox.TabStop = false;
            WeekdayGroupBox.Text = "Weekday parsing";
            WeekdayGroupBox.SizeChanged += WeekdayGroupBox_SizeChanged;
            // 
            // WeekdayTextBox
            // 
            WeekdayTextBox.Location = new Point(6, 38);
            WeekdayTextBox.Name = "WeekdayTextBox";
            WeekdayTextBox.Size = new Size(130, 23);
            WeekdayTextBox.TabIndex = 8;
            // 
            // WeekdayParsingButton
            // 
            WeekdayParsingButton.ImeMode = ImeMode.NoControl;
            WeekdayParsingButton.Location = new Point(142, 38);
            WeekdayParsingButton.Name = "WeekdayParsingButton";
            WeekdayParsingButton.Size = new Size(75, 23);
            WeekdayParsingButton.TabIndex = 8;
            WeekdayParsingButton.Text = "Parse";
            WeekdayParsingButton.UseVisualStyleBackColor = true;
            WeekdayParsingButton.Click += WeekdayParsingButton_Click;
            // 
            // ParsedWeekdayLabel
            // 
            ParsedWeekdayLabel.AutoSize = true;
            ParsedWeekdayLabel.ImeMode = ImeMode.NoControl;
            ParsedWeekdayLabel.Location = new Point(6, 63);
            ParsedWeekdayLabel.Name = "ParsedWeekdayLabel";
            ParsedWeekdayLabel.Size = new Size(103, 15);
            ParsedWeekdayLabel.TabIndex = 1;
            ParsedWeekdayLabel.Text = "Здесь будет ответ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 0;
            label4.Text = "Type value for parsing ";
            // 
            // WeekdayParsing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(WeekdayGroupBox);
            MinimumSize = new Size(230, 90);
            Name = "WeekdayParsing";
            Size = new Size(230, 90);
            WeekdayGroupBox.ResumeLayout(false);
            WeekdayGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox WeekdayGroupBox;
        private TextBox WeekdayTextBox;
        private Button WeekdayParsingButton;
        private Label ParsedWeekdayLabel;
        private Label label4;
    }
}
