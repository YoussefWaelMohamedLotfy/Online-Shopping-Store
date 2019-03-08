namespace Online_Shopping_Store
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.search_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Load_Cat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.choose_CB = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // search_flowLayoutPanel
            // 
            this.search_flowLayoutPanel.AutoScroll = true;
            this.search_flowLayoutPanel.Location = new System.Drawing.Point(-2, 142);
            this.search_flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_flowLayoutPanel.Name = "search_flowLayoutPanel";
            this.search_flowLayoutPanel.Size = new System.Drawing.Size(678, 365);
            this.search_flowLayoutPanel.TabIndex = 95;
            // 
            // Load_Cat
            // 
            this.Load_Cat.ActiveBorderThickness = 1;
            this.Load_Cat.ActiveCornerRadius = 20;
            this.Load_Cat.ActiveFillColor = System.Drawing.Color.Teal;
            this.Load_Cat.ActiveForecolor = System.Drawing.Color.White;
            this.Load_Cat.ActiveLineColor = System.Drawing.Color.Teal;
            this.Load_Cat.BackColor = System.Drawing.SystemColors.Control;
            this.Load_Cat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Load_Cat.BackgroundImage")));
            this.Load_Cat.ButtonText = "Search";
            this.Load_Cat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Load_Cat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_Cat.ForeColor = System.Drawing.Color.Teal;
            this.Load_Cat.IdleBorderThickness = 1;
            this.Load_Cat.IdleCornerRadius = 20;
            this.Load_Cat.IdleFillColor = System.Drawing.Color.White;
            this.Load_Cat.IdleForecolor = System.Drawing.Color.Teal;
            this.Load_Cat.IdleLineColor = System.Drawing.Color.Teal;
            this.Load_Cat.Location = new System.Drawing.Point(439, 90);
            this.Load_Cat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Load_Cat.Name = "Load_Cat";
            this.Load_Cat.Size = new System.Drawing.Size(106, 38);
            this.Load_Cat.TabIndex = 98;
            this.Load_Cat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Load_Cat.Click += new System.EventHandler(this.Load_Cat_Click);
            // 
            // choose_CB
            // 
            this.choose_CB.FormattingEnabled = true;
            this.choose_CB.Items.AddRange(new object[] {
            "Smart Phones",
            "Electronics",
            "Beauty Products",
            "Appliances",
            "Fashion",
            "Furniture"});
            this.choose_CB.Location = new System.Drawing.Point(198, 51);
            this.choose_CB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.choose_CB.Name = "choose_CB";
            this.choose_CB.Size = new System.Drawing.Size(195, 21);
            this.choose_CB.TabIndex = 97;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(32, 46);
            this.bunifuCustomLabel13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(169, 44);
            this.bunifuCustomLabel13.TabIndex = 96;
            this.bunifuCustomLabel13.Text = "Choose Category:\r\n\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 93);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 99;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(46, 89);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 22);
            this.bunifuCustomLabel1.TabIndex = 100;
            this.bunifuCustomLabel1.Text = "Enter name :";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 517);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Load_Cat);
            this.Controls.Add(this.choose_CB);
            this.Controls.Add(this.bunifuCustomLabel13);
            this.Controls.Add(this.search_flowLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Search";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel search_flowLayoutPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 Load_Cat;
        private System.Windows.Forms.ComboBox choose_CB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}