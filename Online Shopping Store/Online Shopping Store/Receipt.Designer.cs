namespace Online_Shopping_Store
{
    partial class Receipt
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
            this.Idlabel_rec = new System.Windows.Forms.Label();
            this.namelabel_rec = new System.Windows.Forms.Label();
            this.Brandlabel_rec = new System.Windows.Forms.Label();
            this.numlabel_rec = new System.Windows.Forms.Label();
            this.Pricelabel_rec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Idlabel_rec
            // 
            this.Idlabel_rec.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idlabel_rec.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Idlabel_rec.Location = new System.Drawing.Point(27, 21);
            this.Idlabel_rec.Name = "Idlabel_rec";
            this.Idlabel_rec.Size = new System.Drawing.Size(100, 23);
            this.Idlabel_rec.TabIndex = 0;
            this.Idlabel_rec.Text = "ll";
            this.Idlabel_rec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namelabel_rec
            // 
            this.namelabel_rec.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel_rec.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.namelabel_rec.Location = new System.Drawing.Point(136, 21);
            this.namelabel_rec.Name = "namelabel_rec";
            this.namelabel_rec.Size = new System.Drawing.Size(100, 23);
            this.namelabel_rec.TabIndex = 1;
            this.namelabel_rec.Text = "ll";
            this.namelabel_rec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Brandlabel_rec
            // 
            this.Brandlabel_rec.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brandlabel_rec.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Brandlabel_rec.Location = new System.Drawing.Point(253, 21);
            this.Brandlabel_rec.Name = "Brandlabel_rec";
            this.Brandlabel_rec.Size = new System.Drawing.Size(100, 23);
            this.Brandlabel_rec.TabIndex = 2;
            this.Brandlabel_rec.Text = "ll";
            this.Brandlabel_rec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numlabel_rec
            // 
            this.numlabel_rec.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numlabel_rec.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.numlabel_rec.Location = new System.Drawing.Point(360, 21);
            this.numlabel_rec.Name = "numlabel_rec";
            this.numlabel_rec.Size = new System.Drawing.Size(100, 23);
            this.numlabel_rec.TabIndex = 3;
            this.numlabel_rec.Text = "ll";
            this.numlabel_rec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pricelabel_rec
            // 
            this.Pricelabel_rec.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricelabel_rec.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Pricelabel_rec.Location = new System.Drawing.Point(470, 21);
            this.Pricelabel_rec.Name = "Pricelabel_rec";
            this.Pricelabel_rec.Size = new System.Drawing.Size(100, 23);
            this.Pricelabel_rec.TabIndex = 4;
            this.Pricelabel_rec.Text = "ll";
            this.Pricelabel_rec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pricelabel_rec);
            this.Controls.Add(this.numlabel_rec);
            this.Controls.Add(this.Brandlabel_rec);
            this.Controls.Add(this.namelabel_rec);
            this.Controls.Add(this.Idlabel_rec);
            this.Name = "Receipt";
            this.Size = new System.Drawing.Size(588, 53);
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Idlabel_rec;
        private System.Windows.Forms.Label namelabel_rec;
        private System.Windows.Forms.Label Brandlabel_rec;
        private System.Windows.Forms.Label numlabel_rec;
        private System.Windows.Forms.Label Pricelabel_rec;
    }
}
