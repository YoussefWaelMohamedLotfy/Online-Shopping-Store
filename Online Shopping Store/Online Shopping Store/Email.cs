using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
//using S22.Imap;

namespace Online_Shopping_Store
{
    public partial class Email : Form
    {

        SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
        MailMessage message = new MailMessage();
      

        public Email()
        {
            InitializeComponent();
        }

        private void Email_Load(object sender, EventArgs e)
        {

        }

        private void Send_but_Click(object sender, EventArgs e)
        {
            var message = new MailMessage(From_text.Text, bunifuMaterialTextbox1.Text);
            message.Subject = subject_txt.Text;
            message.Body = MailBox.Text;
            using (SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com", 587))
            {
                SmtpServer.Credentials = new System.Net.NetworkCredential("ahmedsafwat172@gmail.com", "01116498500");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(message);
                MessageBox.Show("Done");
            }
           
         
        }

        private void cc_txt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void MailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
            Click_label.Visible = true;
        }

        private void Promo_Click(object sender, EventArgs e)
        {
            Promo.Visible = false;
            Click_label.Visible = false;
        }

        private void Promo_MouseLeave(object sender, EventArgs e)
        {
            Click_label.Visible = false;
        }
    }
}
