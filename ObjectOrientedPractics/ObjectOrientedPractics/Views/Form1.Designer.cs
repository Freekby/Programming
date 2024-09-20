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
            MainTabControl = new TabControl();
            ItemsTabPage = new TabPage();
            itemsTab1 = new Views.tabs.ItemsTab();
            CostumersTabPage = new TabPage();
            costumersTab1 = new Views.tabs.CostumersTab();
            MainTabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CostumersTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsTabPage);
            MainTabControl.Controls.Add(CostumersTabPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(591, 463);
            MainTabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(itemsTab1);
            ItemsTabPage.Location = new Point(4, 24);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(583, 435);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.AutoSize = true;
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(577, 429);
            itemsTab1.TabIndex = 0;
            // 
            // CostumersTabPage
            // 
            CostumersTabPage.Controls.Add(costumersTab1);
            CostumersTabPage.Location = new Point(4, 24);
            CostumersTabPage.Name = "CostumersTabPage";
            CostumersTabPage.Padding = new Padding(3);
            CostumersTabPage.Size = new Size(583, 435);
            CostumersTabPage.TabIndex = 1;
            CostumersTabPage.Text = "Costumers";
            CostumersTabPage.UseVisualStyleBackColor = true;
            // 
            // costumersTab1
            // 
            costumersTab1.Location = new Point(0, 0);
            costumersTab1.Name = "costumersTab1";
            costumersTab1.Size = new Size(584, 436);
            costumersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 463);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            Text = "Object Oriented Practices";
            Load += Form1_Load;
            MainTabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            ItemsTabPage.PerformLayout();
            CostumersTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ItemsTabPage;
        private Views.tabs.ItemsTab itemsTab1;
        private TabPage CostumersTabPage;
        private Views.tabs.CostumersTab costumersTab1;
    }
}
