using Backend.Models;
using Backend.Utilities;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using System.Threading.Tasks;

namespace Backend.Services
{
    public interface IEmailService
    {
        void Send(string to, string bcc, string subject, string html);
        Task SendAsync(string to, string bcc, string subject, string html);
    }

    public class EmailService : IEmailService
    {
        private readonly MailSettings _mailSettings;

        public EmailService(MailSettings mailSettings)
        {
            _mailSettings = mailSettings;
        }

        public void Send(string to, string bcc, string subject, string html)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_mailSettings.EmailFrom));
            email.To.Add(MailboxAddress.Parse(to));
            if (!string.IsNullOrWhiteSpace(bcc))
            {
                email.Bcc.Add(MailboxAddress.Parse(bcc)); 
            }
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.SmtpHost, _mailSettings.SmtpPort, SecureSocketOptions.StartTls);
            // https://myaccount.google.com/lesssecureapps
            smtp.Authenticate(_mailSettings.SmtpUser, _mailSettings.SmtpPass);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
        public async Task SendAsync(string to, string bcc, string subject, string html)
        {
            // create message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_mailSettings.EmailFrom));
            email.To.Add(MailboxAddress.Parse(to));
            if (!string.IsNullOrWhiteSpace(bcc))
            {
                email.Bcc.Add(MailboxAddress.Parse(bcc));
            }
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = html };

            // send email
            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_mailSettings.SmtpHost, _mailSettings.SmtpPort, SecureSocketOptions.StartTls);
            // https://myaccount.google.com/lesssecureapps
            await smtp.AuthenticateAsync(_mailSettings.SmtpUser, _mailSettings.SmtpPass);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
        /*
         // gmail
smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

// hotmail
smtp.Connect("smtp.live.com", 587, SecureSocketOptions.StartTls);

// office 365
smtp.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
         */
    }
}
