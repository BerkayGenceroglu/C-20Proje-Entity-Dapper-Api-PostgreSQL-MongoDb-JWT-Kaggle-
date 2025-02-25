using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project16_MailRegister
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        Db16Project20Entities2 veritabanı = new Db16Project20Entities2();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            #region Kayıt
            Random random = new Random();
            int randomcode = random.Next(100000, 1000000);
            TBLUSER user = new TBLUSER();
            user.Name = txtName.Text;
            user.Surname = txtSurname.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.ConfirmCode = randomcode.ToString();
            user.IsConfirm = false;

            veritabanı.TBLUSER.Add(user);
            veritabanı.SaveChanges();

            #endregion

            #region Mail Gönderme
            // MIME: (Multipurpose Internet Mail Extensions) formatında e-posta mesajlarını oluşturmak, işlemek ve göndermek için kullanılan bir sınıftır
            MimeMessage mimeMessage = new MimeMessage();
            //MailboxAddress: Gönderenin veya alıcının isim ve e-posta adresini tutan bir sınıftır.
            MailboxAddress from = new MailboxAddress("BerkayGenceroğlu", "berkaygenceroglu6@gmail.com");
            mimeMessage.From.Add(from);

            MailboxAddress to = new MailboxAddress("User",txtEmail.Text);
            mimeMessage.To.Add(to);

            //E-posta içeriğini (gövdesini) oluşturmak için kullanılır. Metin tabanlı(plain text) veya HTML formatında e-posta içeriği oluşturabilir.
            var bodybuilder = new BodyBuilder();
            //TextBody, e-posta mesajının düz metin (plain text) içeriğini belirler.
            bodybuilder.TextBody = "Email Adresinizin Konfirmasyon Kodu:  " + randomcode;
            #endregion

            //BodyBuilder nesnesinde oluşturduğun metin veya HTML içeriğini MIME uyumlu bir e-posta gövdesine çevirir.
            mimeMessage.Body = bodybuilder.ToMessageBody();
            mimeMessage.Subject = "Email Konfirmasyon Kodu";

            //SmtpClient: E-posta sunucusuna bağlanmak ve e-posta göndermek için kullanılan bir sınıftır.
            //SMTP sunucusuna bağlanır, giriş yapar, mesajı gönderir ve bağlantıyı kapatır.
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587,false);
            client.Authenticate("berkaygenceroglu6@gmail.com", "yonuchgzukucprvs");
            // Gönderici olarak e-posta adresimizi ve şifremizi doğrulamazsak, sunucu bize e-posta gönderme izni vermez.
            client.Send(mimeMessage);
            client.Disconnect(true);

            MessageBox.Show("Mail Başarılı bir Şekilde Gönderildi");

            FrmMailConfirm frmMailConfirm = new FrmMailConfirm();
            frmMailConfirm.email = txtEmail.Text;
            frmMailConfirm.Show();
        }
    }
}
