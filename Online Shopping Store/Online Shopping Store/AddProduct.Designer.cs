namespace Online_Shopping_Store
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.colorCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.AddPhotoLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SizeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.QuantityCB = new System.Windows.Forms.ComboBox();
            this.NotAvailableRadioButton = new System.Windows.Forms.RadioButton();
            this.AvailableRadioButton = new System.Windows.Forms.RadioButton();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.BrandTB = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.CategoryLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BrandLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.QuantityLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ColorLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SizeLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AvailabilityLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DescriptionTB = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.DescriptionLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PriceTB = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.PriceLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MyAcc_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ProductNameLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ProductNameTB = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.AddProductButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BackTB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // colorCheckedListBox
            // 
            this.colorCheckedListBox.FormattingEnabled = true;
            this.colorCheckedListBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Yellow",
            "Salmon",
            "Brown",
            "Red ",
            "Orange",
            "Grey",
            "Blue",
            "StateBlue",
            "SkyBlue",
            "Navy",
            "Green",
            "Dark Green",
            "Purple",
            "violet",
            "Maroon",
            "Beige",
            "Peach",
            "Gold",
            "Pink"});
            this.colorCheckedListBox.Location = new System.Drawing.Point(584, 315);
            this.colorCheckedListBox.Name = "colorCheckedListBox";
            this.colorCheckedListBox.Size = new System.Drawing.Size(120, 80);
            this.colorCheckedListBox.TabIndex = 46;
            // 
            // AddPhotoLabel
            // 
            this.AddPhotoLabel.AutoSize = true;
            this.AddPhotoLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.AddPhotoLabel.Location = new System.Drawing.Point(34, 219);
            this.AddPhotoLabel.Name = "AddPhotoLabel";
            this.AddPhotoLabel.Size = new System.Drawing.Size(134, 54);
            this.AddPhotoLabel.TabIndex = 45;
            this.AddPhotoLabel.Text = "Add Photo:\r\n\r\n";
            // 
            // SizeCheckedListBox
            // 
            this.SizeCheckedListBox.FormattingEnabled = true;
            this.SizeCheckedListBox.Items.AddRange(new object[] {
            "FS",
            "XS",
            "Medium",
            "Large",
            "XL",
            "XXL",
            "XXXL"});
            this.SizeCheckedListBox.Location = new System.Drawing.Point(359, 315);
            this.SizeCheckedListBox.Name = "SizeCheckedListBox";
            this.SizeCheckedListBox.Size = new System.Drawing.Size(120, 80);
            this.SizeCheckedListBox.TabIndex = 44;
            // 
            // QuantityCB
            // 
            this.QuantityCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantityCB.FormattingEnabled = true;
            this.QuantityCB.Items.AddRange(new object[] {
            "1"});
            this.QuantityCB.Location = new System.Drawing.Point(933, 321);
            this.QuantityCB.Name = "QuantityCB";
            this.QuantityCB.Size = new System.Drawing.Size(93, 24);
            this.QuantityCB.TabIndex = 43;
            this.QuantityCB.SelectedIndexChanged += new System.EventHandler(this.QuantityCB_SelectedIndexChanged);
            // 
            // NotAvailableRadioButton
            // 
            this.NotAvailableRadioButton.AutoSize = true;
            this.NotAvailableRadioButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.NotAvailableRadioButton.Location = new System.Drawing.Point(746, 352);
            this.NotAvailableRadioButton.Name = "NotAvailableRadioButton";
            this.NotAvailableRadioButton.Size = new System.Drawing.Size(129, 25);
            this.NotAvailableRadioButton.TabIndex = 42;
            this.NotAvailableRadioButton.TabStop = true;
            this.NotAvailableRadioButton.Text = "Not Available";
            this.NotAvailableRadioButton.UseVisualStyleBackColor = true;
            // 
            // AvailableRadioButton
            // 
            this.AvailableRadioButton.AutoSize = true;
            this.AvailableRadioButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.AvailableRadioButton.Location = new System.Drawing.Point(746, 321);
            this.AvailableRadioButton.Name = "AvailableRadioButton";
            this.AvailableRadioButton.Size = new System.Drawing.Size(98, 25);
            this.AvailableRadioButton.TabIndex = 41;
            this.AvailableRadioButton.TabStop = true;
            this.AvailableRadioButton.Text = "Available";
            this.AvailableRadioButton.UseVisualStyleBackColor = true;
            // 
            // CategoryCB
            // 
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Items.AddRange(new object[] {
            "Smart Phones",
            "Televisions",
            "Fashion",
            "Computers",
            "Beauty Products",
            "Appliances"});
            this.CategoryCB.Location = new System.Drawing.Point(212, 101);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(163, 24);
            this.CategoryCB.TabIndex = 40;
            // 
            // BrandTB
            // 
            this.BrandTB.BorderColor = System.Drawing.Color.Teal;
            this.BrandTB.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BrandTB.Location = new System.Drawing.Point(622, 95);
            this.BrandTB.Name = "BrandTB";
            this.BrandTB.Size = new System.Drawing.Size(214, 34);
            this.BrandTB.TabIndex = 39;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.CategoryLabel.Location = new System.Drawing.Point(-115, 59);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(121, 54);
            this.CategoryLabel.TabIndex = 38;
            this.CategoryLabel.Text = "Category:\r\n\r\n";
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.BrandLabel.Location = new System.Drawing.Point(530, 95);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(86, 54);
            this.BrandLabel.TabIndex = 37;
            this.BrandLabel.Text = "Brand:\r\n\r\n";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.QuantityLabel.Location = new System.Drawing.Point(928, 273);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(116, 54);
            this.QuantityLabel.TabIndex = 36;
            this.QuantityLabel.Text = "Quantity:\r\n\r\n";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.ColorLabel.Location = new System.Drawing.Point(579, 273);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(80, 54);
            this.ColorLabel.TabIndex = 35;
            this.ColorLabel.Text = "Color:\r\n\r\n";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.SizeLabel.Location = new System.Drawing.Point(354, 273);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(66, 54);
            this.SizeLabel.TabIndex = 34;
            this.SizeLabel.Text = "Size:\r\n\r\n";
            // 
            // AvailabilityLabel
            // 
            this.AvailabilityLabel.AutoSize = true;
            this.AvailabilityLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.AvailabilityLabel.Location = new System.Drawing.Point(741, 273);
            this.AvailabilityLabel.Name = "AvailabilityLabel";
            this.AvailabilityLabel.Size = new System.Drawing.Size(145, 54);
            this.AvailabilityLabel.TabIndex = 33;
            this.AvailabilityLabel.Text = "Availability:\r\n\r\n";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.BorderColor = System.Drawing.Color.Teal;
            this.DescriptionTB.Font = new System.Drawing.Font("Tahoma", 13F);
            this.DescriptionTB.Location = new System.Drawing.Point(39, 315);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(218, 165);
            this.DescriptionTB.TabIndex = 32;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.DescriptionLabel.Location = new System.Drawing.Point(34, 273);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(148, 54);
            this.DescriptionLabel.TabIndex = 31;
            this.DescriptionLabel.Text = "Description:\r\n\r\n";
            // 
            // PriceTB
            // 
            this.PriceTB.BorderColor = System.Drawing.Color.Teal;
            this.PriceTB.Font = new System.Drawing.Font("Tahoma", 13F);
            this.PriceTB.Location = new System.Drawing.Point(622, 162);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(214, 34);
            this.PriceTB.TabIndex = 30;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.Location = new System.Drawing.Point(530, 165);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(76, 54);
            this.PriceLabel.TabIndex = 29;
            this.PriceLabel.Text = "Price:\r\n\r\n";
            // 
            // MyAcc_label
            // 
            this.MyAcc_label.AutoSize = true;
            this.MyAcc_label.Font = new System.Drawing.Font("Tahoma", 20F);
            this.MyAcc_label.Location = new System.Drawing.Point(405, 22);
            this.MyAcc_label.Name = "MyAcc_label";
            this.MyAcc_label.Size = new System.Drawing.Size(201, 41);
            this.MyAcc_label.TabIndex = 28;
            this.MyAcc_label.Text = "Add Product";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.ProductNameLabel.Location = new System.Drawing.Point(34, 165);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(177, 54);
            this.ProductNameLabel.TabIndex = 27;
            this.ProductNameLabel.Text = "Product Name:\r\n\r\n";
            // 
            // ProductNameTB
            // 
            this.ProductNameTB.BorderColor = System.Drawing.Color.Teal;
            this.ProductNameTB.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ProductNameTB.Location = new System.Drawing.Point(212, 162);
            this.ProductNameTB.Name = "ProductNameTB";
            this.ProductNameTB.Size = new System.Drawing.Size(300, 34);
            this.ProductNameTB.TabIndex = 26;
            // 
            // AddProductButton
            // 
            this.AddProductButton.ActiveBorderThickness = 2;
            this.AddProductButton.ActiveCornerRadius = 25;
            this.AddProductButton.ActiveFillColor = System.Drawing.Color.PaleTurquoise;
            this.AddProductButton.ActiveForecolor = System.Drawing.Color.Teal;
            this.AddProductButton.ActiveLineColor = System.Drawing.Color.Teal;
            this.AddProductButton.BackColor = System.Drawing.SystemColors.Control;
            this.AddProductButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddProductButton.BackgroundImage")));
            this.AddProductButton.ButtonText = "Add";
            this.AddProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddProductButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.ForeColor = System.Drawing.Color.Teal;
            this.AddProductButton.IdleBorderThickness = 3;
            this.AddProductButton.IdleCornerRadius = 29;
            this.AddProductButton.IdleFillColor = System.Drawing.Color.White;
            this.AddProductButton.IdleForecolor = System.Drawing.Color.Teal;
            this.AddProductButton.IdleLineColor = System.Drawing.Color.Teal;
            this.AddProductButton.Location = new System.Drawing.Point(661, 444);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(197, 57);
            this.AddProductButton.TabIndex = 48;
            this.AddProductButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // BackTB
            // 
            this.BackTB.ActiveBorderThickness = 2;
            this.BackTB.ActiveCornerRadius = 25;
            this.BackTB.ActiveFillColor = System.Drawing.Color.PaleTurquoise;
            this.BackTB.ActiveForecolor = System.Drawing.Color.Teal;
            this.BackTB.ActiveLineColor = System.Drawing.Color.Teal;
            this.BackTB.BackColor = System.Drawing.SystemColors.Control;
            this.BackTB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackTB.BackgroundImage")));
            this.BackTB.ButtonText = "Back";
            this.BackTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackTB.ForeColor = System.Drawing.Color.Teal;
            this.BackTB.IdleBorderThickness = 3;
            this.BackTB.IdleCornerRadius = 29;
            this.BackTB.IdleFillColor = System.Drawing.Color.White;
            this.BackTB.IdleForecolor = System.Drawing.Color.Teal;
            this.BackTB.IdleLineColor = System.Drawing.Color.Teal;
            this.BackTB.Location = new System.Drawing.Point(868, 444);
            this.BackTB.Margin = new System.Windows.Forms.Padding(5);
            this.BackTB.Name = "BackTB";
            this.BackTB.Size = new System.Drawing.Size(197, 57);
            this.BackTB.TabIndex = 47;
            this.BackTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackTB.Click += new System.EventHandler(this.BackTB_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(34, 95);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 54);
            this.bunifuCustomLabel1.TabIndex = 49;
            this.bunifuCustomLabel1.Text = "Category:\r\n\r\n";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 531);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.BackTB);
            this.Controls.Add(this.colorCheckedListBox);
            this.Controls.Add(this.AddPhotoLabel);
            this.Controls.Add(this.SizeCheckedListBox);
            this.Controls.Add(this.QuantityCB);
            this.Controls.Add(this.NotAvailableRadioButton);
            this.Controls.Add(this.AvailableRadioButton);
            this.Controls.Add(this.CategoryCB);
            this.Controls.Add(this.BrandTB);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.AvailabilityLabel);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.MyAcc_label);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductNameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 AddProductButton;
        private Bunifu.Framework.UI.BunifuThinButton2 BackTB;
        private System.Windows.Forms.CheckedListBox colorCheckedListBox;
        private Bunifu.Framework.UI.BunifuCustomLabel AddPhotoLabel;
        private System.Windows.Forms.CheckedListBox SizeCheckedListBox;
        private System.Windows.Forms.ComboBox QuantityCB;
        private System.Windows.Forms.RadioButton NotAvailableRadioButton;
        private System.Windows.Forms.RadioButton AvailableRadioButton;
        private System.Windows.Forms.ComboBox CategoryCB;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox BrandTB;
        private Bunifu.Framework.UI.BunifuCustomLabel CategoryLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel BrandLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel QuantityLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel ColorLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel SizeLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel AvailabilityLabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox DescriptionTB;
        private Bunifu.Framework.UI.BunifuCustomLabel DescriptionLabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox PriceTB;
        private Bunifu.Framework.UI.BunifuCustomLabel PriceLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel MyAcc_label;
        private Bunifu.Framework.UI.BunifuCustomLabel ProductNameLabel;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox ProductNameTB;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}