namespace Online_Shopping_Store
{
    partial class Cart_items
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_usercontrol_product = new System.Windows.Forms.Panel();
            this.brandLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pricelabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_usercontrol_product.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_usercontrol_product
            // 
            this.panel_usercontrol_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_usercontrol_product.Controls.Add(this.brandLabel);
            this.panel_usercontrol_product.Controls.Add(this.label5);
            this.panel_usercontrol_product.Controls.Add(this.pricelabel);
            this.panel_usercontrol_product.Controls.Add(this.idlabel);
            this.panel_usercontrol_product.Controls.Add(this.namelabel);
            this.panel_usercontrol_product.Controls.Add(this.label3);
            this.panel_usercontrol_product.Controls.Add(this.label2);
            this.panel_usercontrol_product.Controls.Add(this.label1);
            this.panel_usercontrol_product.Location = new System.Drawing.Point(3, 3);
            this.panel_usercontrol_product.Name = "panel_usercontrol_product";
            this.panel_usercontrol_product.Size = new System.Drawing.Size(335, 73);
            this.panel_usercontrol_product.TabIndex = 2;
            this.panel_usercontrol_product.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_usercontrol_product_Paint);
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(276, 46);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(35, 13);
            this.brandLabel.TabIndex = 34;
            this.brandLabel.Text = "label7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Brand";
            // 
            // pricelabel
            // 
            this.pricelabel.AutoSize = true;
            this.pricelabel.Location = new System.Drawing.Point(276, 9);
            this.pricelabel.Name = "pricelabel";
            this.pricelabel.Size = new System.Drawing.Size(35, 13);
            this.pricelabel.TabIndex = 28;
            this.pricelabel.Text = "label7";
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(89, 46);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(35, 13);
            this.idlabel.TabIndex = 27;
            this.idlabel.Text = "label6";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(89, 9);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 26;
            this.namelabel.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name";
            // 
            // Cart_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_usercontrol_product);
            this.Name = "Cart_items";
            this.Size = new System.Drawing.Size(342, 80);
            this.panel_usercontrol_product.ResumeLayout(false);
            this.panel_usercontrol_product.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_usercontrol_product;
        private System.Windows.Forms.Label pricelabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label label5;
    }
}
