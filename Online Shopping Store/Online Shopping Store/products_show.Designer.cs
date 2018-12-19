namespace Online_Shopping_Store
{
    partial class products_show
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productsShow_menuStrip = new System.Windows.Forms.MenuStrip();
            this.showCart_MenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Smart_Phones_tab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Fashion_Tab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.Furniture_tab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.Electronics_tab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Applieances_tab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Beauty_Product_tab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsShow_menuStrip.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Smart_Phones_tab.SuspendLayout();
            this.Fashion_Tab.SuspendLayout();
            this.Furniture_tab.SuspendLayout();
            this.Electronics_tab.SuspendLayout();
            this.Applieances_tab.SuspendLayout();
            this.Beauty_Product_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // productsShow_menuStrip
            // 
            this.productsShow_menuStrip.BackColor = System.Drawing.Color.Honeydew;
            this.productsShow_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCart_MenuOption,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.productsShow_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.productsShow_menuStrip.Name = "productsShow_menuStrip";
            this.productsShow_menuStrip.Size = new System.Drawing.Size(841, 24);
            this.productsShow_menuStrip.TabIndex = 1;
            this.productsShow_menuStrip.Text = "menuStrip1";
            this.productsShow_menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.productsShow_menuStrip_ItemClicked);
            // 
            // showCart_MenuOption
            // 
            this.showCart_MenuOption.Name = "showCart_MenuOption";
            this.showCart_MenuOption.Size = new System.Drawing.Size(52, 20);
            this.showCart_MenuOption.Text = "Home";
            this.showCart_MenuOption.Click += new System.EventHandler(this.showCart_MenuOption_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Smart_Phones_tab);
            this.tabControl1.Controls.Add(this.Fashion_Tab);
            this.tabControl1.Controls.Add(this.Furniture_tab);
            this.tabControl1.Controls.Add(this.Electronics_tab);
            this.tabControl1.Controls.Add(this.Applieances_tab);
            this.tabControl1.Controls.Add(this.Beauty_Product_tab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(841, 632);
            this.tabControl1.TabIndex = 2;
            // 
            // Smart_Phones_tab
            // 
            this.Smart_Phones_tab.Controls.Add(this.flowLayoutPanel1);
            this.Smart_Phones_tab.Location = new System.Drawing.Point(4, 22);
            this.Smart_Phones_tab.Name = "Smart_Phones_tab";
            this.Smart_Phones_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Smart_Phones_tab.Size = new System.Drawing.Size(833, 606);
            this.Smart_Phones_tab.TabIndex = 0;
            this.Smart_Phones_tab.Text = "Smart Phones";
            this.Smart_Phones_tab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(827, 600);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Fashion_Tab
            // 
            this.Fashion_Tab.Controls.Add(this.flowLayoutPanel5);
            this.Fashion_Tab.Location = new System.Drawing.Point(4, 22);
            this.Fashion_Tab.Name = "Fashion_Tab";
            this.Fashion_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Fashion_Tab.Size = new System.Drawing.Size(833, 606);
            this.Fashion_Tab.TabIndex = 1;
            this.Fashion_Tab.Text = "Fashion";
            this.Fashion_Tab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(827, 600);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // Furniture_tab
            // 
            this.Furniture_tab.Controls.Add(this.flowLayoutPanel6);
            this.Furniture_tab.Location = new System.Drawing.Point(4, 22);
            this.Furniture_tab.Name = "Furniture_tab";
            this.Furniture_tab.Size = new System.Drawing.Size(833, 606);
            this.Furniture_tab.TabIndex = 2;
            this.Furniture_tab.Text = "Furniture";
            this.Furniture_tab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoScroll = true;
            this.flowLayoutPanel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(833, 606);
            this.flowLayoutPanel6.TabIndex = 1;
            // 
            // Electronics_tab
            // 
            this.Electronics_tab.Controls.Add(this.flowLayoutPanel4);
            this.Electronics_tab.Location = new System.Drawing.Point(4, 22);
            this.Electronics_tab.Name = "Electronics_tab";
            this.Electronics_tab.Size = new System.Drawing.Size(833, 606);
            this.Electronics_tab.TabIndex = 3;
            this.Electronics_tab.Text = "Electronics";
            this.Electronics_tab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(833, 606);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // Applieances_tab
            // 
            this.Applieances_tab.Controls.Add(this.flowLayoutPanel2);
            this.Applieances_tab.Location = new System.Drawing.Point(4, 22);
            this.Applieances_tab.Name = "Applieances_tab";
            this.Applieances_tab.Size = new System.Drawing.Size(833, 606);
            this.Applieances_tab.TabIndex = 4;
            this.Applieances_tab.Text = "Applieances";
            this.Applieances_tab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(833, 606);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // Beauty_Product_tab
            // 
            this.Beauty_Product_tab.Controls.Add(this.flowLayoutPanel3);
            this.Beauty_Product_tab.Location = new System.Drawing.Point(4, 22);
            this.Beauty_Product_tab.Name = "Beauty_Product_tab";
            this.Beauty_Product_tab.Size = new System.Drawing.Size(833, 606);
            this.Beauty_Product_tab.TabIndex = 5;
            this.Beauty_Product_tab.Text = "Beauty Product";
            this.Beauty_Product_tab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(833, 606);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // products_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 632);
            this.Controls.Add(this.productsShow_menuStrip);
            this.Controls.Add(this.tabControl1);
            this.Name = "products_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products_show";
            this.Load += new System.EventHandler(this.products_show_Load);
            this.productsShow_menuStrip.ResumeLayout(false);
            this.productsShow_menuStrip.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Smart_Phones_tab.ResumeLayout(false);
            this.Fashion_Tab.ResumeLayout(false);
            this.Furniture_tab.ResumeLayout(false);
            this.Electronics_tab.ResumeLayout(false);
            this.Applieances_tab.ResumeLayout(false);
            this.Beauty_Product_tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem showCart_MenuOption;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        public System.Windows.Forms.MenuStrip productsShow_menuStrip;
        public System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.TabPage Smart_Phones_tab;
        public System.Windows.Forms.TabPage Fashion_Tab;
        public System.Windows.Forms.TabPage Furniture_tab;
        public System.Windows.Forms.TabPage Electronics_tab;
        public System.Windows.Forms.TabPage Applieances_tab;
        public System.Windows.Forms.TabPage Beauty_Product_tab;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}