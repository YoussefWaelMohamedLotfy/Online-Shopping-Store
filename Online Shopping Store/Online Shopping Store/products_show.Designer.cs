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
            this.productsDisplay_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // productsDisplay_FlowLayoutPanel
            // 
            this.productsDisplay_FlowLayoutPanel.AutoScroll = true;
            this.productsDisplay_FlowLayoutPanel.Location = new System.Drawing.Point(1, 3);
            this.productsDisplay_FlowLayoutPanel.Name = "productsDisplay_FlowLayoutPanel";
            this.productsDisplay_FlowLayoutPanel.Size = new System.Drawing.Size(703, 427);
            this.productsDisplay_FlowLayoutPanel.TabIndex = 0;
            // 
            // products_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 431);
            this.Controls.Add(this.productsDisplay_FlowLayoutPanel);
            this.Name = "products_show";
            this.Text = "products_show";
            this.Load += new System.EventHandler(this.products_show_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel productsDisplay_FlowLayoutPanel;
    }
}