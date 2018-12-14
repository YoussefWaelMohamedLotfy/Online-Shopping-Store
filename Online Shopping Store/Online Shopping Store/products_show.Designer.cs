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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productsShow_menuStrip = new System.Windows.Forms.MenuStrip();
            this.showCart_MenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.productsShow_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(735, 608);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // productsShow_menuStrip
            // 
            this.productsShow_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCart_MenuOption});
            this.productsShow_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.productsShow_menuStrip.Name = "productsShow_menuStrip";
            this.productsShow_menuStrip.Size = new System.Drawing.Size(735, 24);
            this.productsShow_menuStrip.TabIndex = 1;
            this.productsShow_menuStrip.Text = "menuStrip1";
            // 
            // showCart_MenuOption
            // 
            this.showCart_MenuOption.Name = "showCart_MenuOption";
            this.showCart_MenuOption.Size = new System.Drawing.Size(73, 20);
            this.showCart_MenuOption.Text = "Show Cart";
            this.showCart_MenuOption.Click += new System.EventHandler(this.showCart_MenuOption_Click);
            // 
            // products_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 632);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.productsShow_menuStrip);
            this.Name = "products_show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "products_show";
            this.Load += new System.EventHandler(this.products_show_Load);
            this.productsShow_menuStrip.ResumeLayout(false);
            this.productsShow_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip productsShow_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem showCart_MenuOption;
    }
}