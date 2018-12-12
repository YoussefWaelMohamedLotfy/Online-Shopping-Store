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
            this.SizeCheckedListBox = new System.Windows.Forms.CheckedListBox();
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
            this.quantityCount = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ProductIdTB = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.AddPhoto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quantityCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.colorCheckedListBox.Location = new System.Drawing.Point(256, 329);
            this.colorCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.colorCheckedListBox.Name = "colorCheckedListBox";
            this.colorCheckedListBox.Size = new System.Drawing.Size(136, 72);
            this.colorCheckedListBox.TabIndex = 46;
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
            this.SizeCheckedListBox.Location = new System.Drawing.Point(13, 329);
            this.SizeCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SizeCheckedListBox.Name = "SizeCheckedListBox";
            this.SizeCheckedListBox.Size = new System.Drawing.Size(136, 72);
            this.SizeCheckedListBox.TabIndex = 44;
            // 
            // NotAvailableRadioButton
            // 
            this.NotAvailableRadioButton.AutoSize = true;
            this.NotAvailableRadioButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.NotAvailableRadioButton.Location = new System.Drawing.Point(446, 376);
            this.NotAvailableRadioButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.AvailableRadioButton.Location = new System.Drawing.Point(451, 329);
            this.AvailableRadioButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.CategoryCB.Location = new System.Drawing.Point(232, 15);
            this.CategoryCB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.Size = new System.Drawing.Size(185, 24);
            this.CategoryCB.TabIndex = 40;
            // 
            // BrandTB
            // 
            this.BrandTB.BorderColor = System.Drawing.Color.Teal;
            this.BrandTB.Font = new System.Drawing.Font("Tahoma", 13F);
            this.BrandTB.Location = new System.Drawing.Point(232, 168);
            this.BrandTB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BrandTB.Name = "BrandTB";
            this.BrandTB.Size = new System.Drawing.Size(244, 34);
            this.BrandTB.TabIndex = 39;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.CategoryLabel.Location = new System.Drawing.Point(-132, 59);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(121, 54);
            this.CategoryLabel.TabIndex = 38;
            this.CategoryLabel.Text = "Category:\r\n\r\n";
            // 
            // BrandLabel
            // 
            this.BrandLabel.AutoSize = true;
            this.BrandLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.BrandLabel.Location = new System.Drawing.Point(39, 171);
            this.BrandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(86, 54);
            this.BrandLabel.TabIndex = 37;
            this.BrandLabel.Text = "Brand:\r\n\r\n";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.QuantityLabel.Location = new System.Drawing.Point(13, 457);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(116, 54);
            this.QuantityLabel.TabIndex = 36;
            this.QuantityLabel.Text = "Quantity:\r\n\r\n";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.ColorLabel.Location = new System.Drawing.Point(251, 273);
            this.ColorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(80, 54);
            this.ColorLabel.TabIndex = 35;
            this.ColorLabel.Text = "Color:\r\n\r\n";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.SizeLabel.Location = new System.Drawing.Point(19, 273);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(66, 54);
            this.SizeLabel.TabIndex = 34;
            this.SizeLabel.Text = "Size:\r\n\r\n";
            // 
            // AvailabilityLabel
            // 
            this.AvailabilityLabel.AutoSize = true;
            this.AvailabilityLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.AvailabilityLabel.Location = new System.Drawing.Point(446, 283);
            this.AvailabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvailabilityLabel.Name = "AvailabilityLabel";
            this.AvailabilityLabel.Size = new System.Drawing.Size(145, 54);
            this.AvailabilityLabel.TabIndex = 33;
            this.AvailabilityLabel.Text = "Availability:\r\n\r\n";
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.BorderColor = System.Drawing.Color.Teal;
            this.DescriptionTB.Font = new System.Drawing.Font("Tahoma", 13F);
            this.DescriptionTB.Location = new System.Drawing.Point(995, 346);
            this.DescriptionTB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(248, 165);
            this.DescriptionTB.TabIndex = 32;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.DescriptionLabel.Location = new System.Drawing.Point(773, 349);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(148, 54);
            this.DescriptionLabel.TabIndex = 31;
            this.DescriptionLabel.Text = "Description:\r\n\r\n";
            // 
            // PriceTB
            // 
            this.PriceTB.BorderColor = System.Drawing.Color.Teal;
            this.PriceTB.Font = new System.Drawing.Font("Tahoma", 13F);
            this.PriceTB.Location = new System.Drawing.Point(232, 216);
            this.PriceTB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(244, 34);
            this.PriceTB.TabIndex = 30;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.Location = new System.Drawing.Point(39, 219);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(76, 54);
            this.PriceLabel.TabIndex = 29;
            this.PriceLabel.Text = "Price:\r\n\r\n";
            // 
            // MyAcc_label
            // 
            this.MyAcc_label.AutoSize = true;
            this.MyAcc_label.Font = new System.Drawing.Font("Tahoma", 20F);
            this.MyAcc_label.Location = new System.Drawing.Point(563, 9);
            this.MyAcc_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MyAcc_label.Name = "MyAcc_label";
            this.MyAcc_label.Size = new System.Drawing.Size(201, 41);
            this.MyAcc_label.TabIndex = 28;
            this.MyAcc_label.Text = "Add Product";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.ProductNameLabel.Location = new System.Drawing.Point(13, 63);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(177, 54);
            this.ProductNameLabel.TabIndex = 27;
            this.ProductNameLabel.Text = "Product Name:\r\n\r\n";
            // 
            // ProductNameTB
            // 
            this.ProductNameTB.BorderColor = System.Drawing.Color.Teal;
            this.ProductNameTB.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ProductNameTB.Location = new System.Drawing.Point(232, 63);
            this.ProductNameTB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ProductNameTB.Name = "ProductNameTB";
            this.ProductNameTB.Size = new System.Drawing.Size(343, 34);
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
            this.AddProductButton.Location = new System.Drawing.Point(404, 457);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(225, 57);
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
            this.BackTB.Location = new System.Drawing.Point(663, 454);
            this.BackTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BackTB.Name = "BackTB";
            this.BackTB.Size = new System.Drawing.Size(225, 57);
            this.BackTB.TabIndex = 47;
            this.BackTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackTB.Click += new System.EventHandler(this.BackTB_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(39, 9);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 54);
            this.bunifuCustomLabel1.TabIndex = 49;
            this.bunifuCustomLabel1.Text = "Category:\r\n\r\n";
            // 
            // quantityCount
            // 
            this.quantityCount.Location = new System.Drawing.Point(171, 464);
            this.quantityCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quantityCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityCount.Name = "quantityCount";
            this.quantityCount.Size = new System.Drawing.Size(160, 22);
            this.quantityCount.TabIndex = 50;
            this.quantityCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityCount.ThousandsSeparator = true;
            this.quantityCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(19, 117);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(141, 54);
            this.bunifuCustomLabel2.TabIndex = 51;
            this.bunifuCustomLabel2.Text = "Product ID:\r\n\r\n";
            // 
            // ProductIdTB
            // 
            this.ProductIdTB.BorderColor = System.Drawing.Color.Teal;
            this.ProductIdTB.Font = new System.Drawing.Font("Tahoma", 13F);
            this.ProductIdTB.Location = new System.Drawing.Point(232, 118);
            this.ProductIdTB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ProductIdTB.Name = "ProductIdTB";
            this.ProductIdTB.Size = new System.Drawing.Size(343, 34);
            this.ProductIdTB.TabIndex = 52;
            // 
            // AddPhoto
            // 
            this.AddPhoto.ActiveBorderThickness = 2;
            this.AddPhoto.ActiveCornerRadius = 25;
            this.AddPhoto.ActiveFillColor = System.Drawing.Color.PaleTurquoise;
            this.AddPhoto.ActiveForecolor = System.Drawing.Color.Teal;
            this.AddPhoto.ActiveLineColor = System.Drawing.Color.Teal;
            this.AddPhoto.BackColor = System.Drawing.SystemColors.Control;
            this.AddPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPhoto.BackgroundImage")));
            this.AddPhoto.ButtonText = "Add Photo";
            this.AddPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPhoto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPhoto.ForeColor = System.Drawing.Color.Teal;
            this.AddPhoto.IdleBorderThickness = 3;
            this.AddPhoto.IdleCornerRadius = 29;
            this.AddPhoto.IdleFillColor = System.Drawing.Color.White;
            this.AddPhoto.IdleForecolor = System.Drawing.Color.Teal;
            this.AddPhoto.IdleLineColor = System.Drawing.Color.Teal;
            this.AddPhoto.Location = new System.Drawing.Point(601, 145);
            this.AddPhoto.Margin = new System.Windows.Forms.Padding(5);
            this.AddPhoto.Name = "AddPhoto";
            this.AddPhoto.Size = new System.Drawing.Size(151, 57);
            this.AddPhoto.TabIndex = 53;
            this.AddPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddPhoto.Click += new System.EventHandler(this.AddPhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(761, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 232);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 530);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddPhoto);
            this.Controls.Add(this.ProductIdTB);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.quantityCount);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.BackTB);
            this.Controls.Add(this.colorCheckedListBox);
            this.Controls.Add(this.SizeCheckedListBox);
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
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.quantityCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 AddProductButton;
        private Bunifu.Framework.UI.BunifuThinButton2 BackTB;
        private System.Windows.Forms.CheckedListBox colorCheckedListBox;
        private System.Windows.Forms.CheckedListBox SizeCheckedListBox;
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
        private System.Windows.Forms.NumericUpDown quantityCount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox ProductIdTB;
        private Bunifu.Framework.UI.BunifuThinButton2 AddPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}