namespace Online_Shopping_Store
{
    partial class Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Email));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MailBox = new System.Windows.Forms.RichTextBox();
            this.From_text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.subject_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Send_but = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.Promo = new Bunifu.Framework.UI.BunifuImageButton();
            this.Click_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Promo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(20, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject";
            // 
            // MailBox
            // 
            this.MailBox.AutoWordSelection = true;
            this.MailBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.MailBox.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailBox.ForeColor = System.Drawing.SystemColors.Info;
            this.MailBox.Location = new System.Drawing.Point(12, 181);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(453, 150);
            this.MailBox.TabIndex = 3;
            this.MailBox.Text = "";
            this.MailBox.TextChanged += new System.EventHandler(this.MailBox_TextChanged);
            // 
            // From_text
            // 
            this.From_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.From_text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.From_text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.From_text.HintForeColor = System.Drawing.Color.Empty;
            this.From_text.HintText = "";
            this.From_text.isPassword = false;
            this.From_text.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.From_text.LineIdleColor = System.Drawing.Color.Gray;
            this.From_text.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.From_text.LineThickness = 2;
            this.From_text.Location = new System.Drawing.Point(77, 11);
            this.From_text.Margin = new System.Windows.Forms.Padding(4);
            this.From_text.Name = "From_text";
            this.From_text.Size = new System.Drawing.Size(336, 25);
            this.From_text.TabIndex = 13;
            this.From_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // subject_txt
            // 
            this.subject_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subject_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.subject_txt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.subject_txt.HintForeColor = System.Drawing.Color.Empty;
            this.subject_txt.HintText = "";
            this.subject_txt.isPassword = false;
            this.subject_txt.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.subject_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.subject_txt.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.subject_txt.LineThickness = 2;
            this.subject_txt.Location = new System.Drawing.Point(80, 114);
            this.subject_txt.Margin = new System.Windows.Forms.Padding(4);
            this.subject_txt.Name = "subject_txt";
            this.subject_txt.Size = new System.Drawing.Size(336, 25);
            this.subject_txt.TabIndex = 15;
            this.subject_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Send_but
            // 
            this.Send_but.ActiveBorderThickness = 1;
            this.Send_but.ActiveCornerRadius = 20;
            this.Send_but.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Send_but.ActiveForecolor = System.Drawing.Color.White;
            this.Send_but.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Send_but.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Send_but.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Send_but.BackgroundImage")));
            this.Send_but.ButtonText = "Send";
            this.Send_but.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Send_but.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send_but.ForeColor = System.Drawing.Color.SeaGreen;
            this.Send_but.IdleBorderThickness = 1;
            this.Send_but.IdleCornerRadius = 20;
            this.Send_but.IdleFillColor = System.Drawing.Color.White;
            this.Send_but.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Send_but.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Send_but.Location = new System.Drawing.Point(368, 339);
            this.Send_but.Margin = new System.Windows.Forms.Padding(5);
            this.Send_but.Name = "Send_but";
            this.Send_but.Size = new System.Drawing.Size(108, 43);
            this.Send_but.TabIndex = 16;
            this.Send_but.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Send_but.Click += new System.EventHandler(this.Send_but_Click);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.bunifuMaterialTextbox1.LineThickness = 2;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(79, 81);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(336, 25);
            this.bunifuMaterialTextbox1.TabIndex = 18;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "To";
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = true;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.SlateGray;
            this.bunifuMaterialTextbox2.LineThickness = 2;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(81, 49);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(336, 25);
            this.bunifuMaterialTextbox2.TabIndex = 20;
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(5, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Password";
            // 
            // Promo
            // 
            this.Promo.BackColor = System.Drawing.Color.Transparent;
            this.Promo.Image = ((System.Drawing.Image)(resources.GetObject("Promo.Image")));
            this.Promo.ImageActive = ((System.Drawing.Image)(resources.GetObject("Promo.ImageActive")));
            this.Promo.InitialImage = null;
            this.Promo.Location = new System.Drawing.Point(-7, 0);
            this.Promo.Name = "Promo";
            this.Promo.Size = new System.Drawing.Size(493, 408);
            this.Promo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Promo.TabIndex = 21;
            this.Promo.TabStop = false;
            this.Promo.Zoom = 10;
            this.Promo.Click += new System.EventHandler(this.Promo_Click);
            this.Promo.MouseLeave += new System.EventHandler(this.Promo_MouseLeave);
            this.Promo.MouseHover += new System.EventHandler(this.bunifuImageButton1_MouseHover);
            // 
            // Click_label
            // 
            this.Click_label.AutoSize = true;
            this.Click_label.BackColor = System.Drawing.Color.Honeydew;
            this.Click_label.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Click_label.ForeColor = System.Drawing.Color.Brown;
            this.Click_label.Location = new System.Drawing.Point(200, 334);
            this.Click_label.Name = "Click_label";
            this.Click_label.Size = new System.Drawing.Size(69, 25);
            this.Click_label.TabIndex = 22;
            this.Click_label.Text = "Click";
            this.Click_label.Visible = false;
            // 
            // Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(477, 385);
            this.Controls.Add(this.Click_label);
            this.Controls.Add(this.Promo);
            this.Controls.Add(this.bunifuMaterialTextbox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuMaterialTextbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Send_but);
            this.Controls.Add(this.subject_txt);
            this.Controls.Add(this.From_text);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Email";
            this.Text = "Email";
            this.Load += new System.EventHandler(this.Email_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Promo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox MailBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox From_text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox subject_txt;
        private Bunifu.Framework.UI.BunifuThinButton2 Send_but;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuImageButton Promo;
        private System.Windows.Forms.Label Click_label;
    }
}