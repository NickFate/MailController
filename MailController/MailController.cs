using System.Net;
using System.Net.Mail;

namespace MailController
{
    public class MailController 
    {
        private SmtpClient client;
        MailMessage message;

        public MailController(string emailAdress, string password)
        {
            // адрес отправителя, имя(заголовок), которое будет напечатано как название письма
            MailAddress from = new MailAddress(emailAdress, "From MailController");

            // адрес получателя (в нашем случае адресс отправителя)
            MailAddress to = new MailAddress(emailAdress);

            // сообщение от "from" к "to" 
            message = new MailMessage(from, to);

            // клиент для отправки сообщения
            client = new SmtpClient("smtp.gmail.com", 587);
            // авторизация
            client.Credentials = new NetworkCredential(emailAdress, password);
            // включаем SSL
            client.EnableSsl = true;
            
        }

        public void SendMessage(string subject, string message)
        {
            // работа с сообщениями 
            
            // Тема
            this.message.Subject = subject;

            // Тело сообщения
            this.message.Body = message;


            // отправляем сообщение
            client.Send(this.message);
        }

    }
}