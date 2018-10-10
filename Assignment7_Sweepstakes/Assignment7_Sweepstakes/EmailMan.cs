using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Mail;



namespace Assignment7_Sweepstakes
{
    static class EmailMan
    {
        public static void SendWinnerMessageTo(string winnersEmail)
        {
            MailAddress sender = new MailAddress("ab6343416@gmail.com");
            MailAddress recipient = new MailAddress(winnersEmail);
            MailMessage message = new MailMessage(sender, recipient);
            message.Subject = "Congration!";
            message.Body = "You won!!";

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("ab6343416@gmail.com", "HorseBatteryStaple");
            client.Send(message);
        }
    }
}
