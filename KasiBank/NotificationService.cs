using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasiATM
{
    public class NotificationService
    {
        public static void SendMessage(bool sendEmail, string toEmail, string toNumber, string message)
        {
            if(sendEmail)
                SendEmail(toEmail, message);

            SendSMS(toNumber,message);
        }
        public static void SendEmail(string toEmail, string message)
        {
            Console.WriteLine($"Sending email to {toEmail}");
            Console.WriteLine(message);
        }

        public static void SendSMS(string toNumber, string message)
        {
            Console.WriteLine($"Sending email to {toNumber}");
            Console.WriteLine(message);
        }
    }
}
