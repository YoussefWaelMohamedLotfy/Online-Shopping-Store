namespace Online_Shopping_Store
{
    partial class ReceiptItem
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
            this.name_receiptLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.price_receiptLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.number_receiptLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.totalItemsPrice_receiptLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // name_receiptLabel
            // 
            this.name_receiptLabel.AutoSize = true;
            this.name_receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_receiptLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_receiptLabel.Location = new System.Drawing.Point(17, 27);
            this.name_receiptLabel.Name = "name_receiptLabel";
            this.name_receiptLabel.Size = new System.Drawing.Size(70, 28);
            this.name_receiptLabel.TabIndex = 0;
            this.name_receiptLabel.Text = "Name";
            // 
            // price_receiptLabel
            // 
            this.price_receiptLabel.AutoSize = true;
            this.price_receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price_receiptLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_receiptLabel.Location = new System.Drawing.Point(158, 27);
            this.price_receiptLabel.Name = "price_receiptLabel";
            this.price_receiptLabel.Size = new System.Drawing.Size(59, 28);
            this.price_receiptLabel.TabIndex = 1;
            this.price_receiptLabel.Text = "Price";
            // 
            // number_receiptLabel
            // 
            this.number_receiptLabel.AutoSize = true;
            this.number_receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.number_receiptLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_receiptLabel.Location = new System.Drawing.Point(287, 27);
            this.number_receiptLabel.Name = "number_receiptLabel";
            this.number_receiptLabel.Size = new System.Drawing.Size(90, 28);
            this.number_receiptLabel.TabIndex = 2;
            this.number_receiptLabel.Text = "Number";
            // 
            // totalItemsPrice_receiptLabel
            // 
            this.totalItemsPrice_receiptLabel.AutoSize = true;
            this.totalItemsPrice_receiptLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalItemsPrice_receiptLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemsPrice_receiptLabel.Location = new System.Drawing.Point(453, 27);
            this.totalItemsPrice_receiptLabel.Name = "totalItemsPrice_receiptLabel";
            this.totalItemsPrice_receiptLabel.Size = new System.Drawing.Size(60, 28);
            this.totalItemsPrice_receiptLabel.TabIndex = 3;
            this.totalItemsPrice_receiptLabel.Text = "Total";
            // 
            // ReceiptItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.totalItemsPrice_receiptLabel);
            this.Controls.Add(this.number_receiptLabel);
            this.Controls.Add(this.price_receiptLabel);
            this.Controls.Add(this.name_receiptLabel);
            this.Name = "ReceiptItem";
            this.Size = new System.Drawing.Size(553, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel name_receiptLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel price_receiptLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel number_receiptLabel;
        public Bunifu.Framework.UI.BunifuCustomLabel totalItemsPrice_receiptLabel;
    }
}
