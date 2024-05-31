namespace BookList
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
            BookInfoGroupBox = new GroupBox();
            GenreComboBox = new ComboBox();
            NumOfPagesTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            YearTextBox = new TextBox();
            TitleTextBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BooksListBox = new ListBox();
            SaveBookInfoButton = new Button();
            AddBookButton = new Button();
            RemoveBookButton = new Button();
            BookInfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // BookInfoGroupBox
            // 
            BookInfoGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BookInfoGroupBox.Controls.Add(GenreComboBox);
            BookInfoGroupBox.Controls.Add(NumOfPagesTextBox);
            BookInfoGroupBox.Controls.Add(AuthorTextBox);
            BookInfoGroupBox.Controls.Add(YearTextBox);
            BookInfoGroupBox.Controls.Add(TitleTextBox);
            BookInfoGroupBox.Controls.Add(label5);
            BookInfoGroupBox.Controls.Add(label4);
            BookInfoGroupBox.Controls.Add(label3);
            BookInfoGroupBox.Controls.Add(label2);
            BookInfoGroupBox.Controls.Add(label1);
            BookInfoGroupBox.Location = new Point(268, 13);
            BookInfoGroupBox.Name = "BookInfoGroupBox";
            BookInfoGroupBox.Size = new Size(520, 172);
            BookInfoGroupBox.TabIndex = 3;
            BookInfoGroupBox.TabStop = false;
            BookInfoGroupBox.Text = "Book Information ";
            // 
            // GenreComboBox
            // 
            GenreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(111, 132);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(100, 23);
            GenreComboBox.TabIndex = 9;
            // 
            // NumOfPagesTextBox
            // 
            NumOfPagesTextBox.Location = new Point(111, 103);
            NumOfPagesTextBox.Name = "NumOfPagesTextBox";
            NumOfPagesTextBox.Size = new Size(100, 23);
            NumOfPagesTextBox.TabIndex = 8;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(111, 74);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(100, 23);
            AuthorTextBox.TabIndex = 7;
            // 
            // YearTextBox
            // 
            YearTextBox.Location = new Point(111, 45);
            YearTextBox.Name = "YearTextBox";
            YearTextBox.Size = new Size(100, 23);
            YearTextBox.TabIndex = 6;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(111, 16);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(100, 23);
            TitleTextBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 135);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 106);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "Number of pages";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 77);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 48);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Year";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 19);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // BooksListBox
            // 
            BooksListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BooksListBox.FormattingEnabled = true;
            BooksListBox.ItemHeight = 15;
            BooksListBox.Location = new Point(12, 13);
            BooksListBox.MinimumSize = new Size(250, 200);
            BooksListBox.Name = "BooksListBox";
            BooksListBox.Size = new Size(250, 424);
            BooksListBox.Sorted = true;
            BooksListBox.TabIndex = 2;
            BooksListBox.SelectedIndexChanged += BooksListBox_SelectedIndexChanged;
            // 
            // SaveBookInfoButton
            // 
            SaveBookInfoButton.Location = new Point(268, 191);
            SaveBookInfoButton.Name = "SaveBookInfoButton";
            SaveBookInfoButton.Size = new Size(75, 23);
            SaveBookInfoButton.TabIndex = 5;
            SaveBookInfoButton.Text = "Save";
            SaveBookInfoButton.UseVisualStyleBackColor = true;
            SaveBookInfoButton.Click += SaveBookInfoButton_Click;
            // 
            // AddBookButton
            // 
            AddBookButton.Location = new Point(349, 191);
            AddBookButton.Name = "AddBookButton";
            AddBookButton.Size = new Size(75, 23);
            AddBookButton.TabIndex = 6;
            AddBookButton.Text = "Add";
            AddBookButton.UseVisualStyleBackColor = true;
            AddBookButton.Click += AddBookButton_Click;
            // 
            // RemoveBookButton
            // 
            RemoveBookButton.Location = new Point(430, 191);
            RemoveBookButton.Name = "RemoveBookButton";
            RemoveBookButton.Size = new Size(75, 23);
            RemoveBookButton.TabIndex = 7;
            RemoveBookButton.Text = "Remove";
            RemoveBookButton.UseVisualStyleBackColor = true;
            RemoveBookButton.Click += RemoveBookButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RemoveBookButton);
            Controls.Add(AddBookButton);
            Controls.Add(SaveBookInfoButton);
            Controls.Add(BookInfoGroupBox);
            Controls.Add(BooksListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Books";
            FormClosing += MainForm_FormClosing;
            Load += Form1_Load;
            BookInfoGroupBox.ResumeLayout(false);
            BookInfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BookInfoGroupBox;
        private ComboBox GenreComboBox;
        private TextBox NumOfPagesTextBox;
        private TextBox AuthorTextBox;
        private TextBox YearTextBox;
        private TextBox TitleTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox BooksListBox;
        private Button SaveBookInfoButton;
        private Button AddBookButton;
        private Button RemoveBookButton;
    }
}