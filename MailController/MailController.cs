using System.Net;
using System.Net.Mail;

namespace MailController
{

    /// <summary>
    /// Класс для отпраки сообщений
    /// </summary>
    public class MailController 
    {
        private SmtpClient client;
        MailMessage message;

        MailAddress from;

        /// <summary>
        /// Класс для отпраки сообщений
        /// </summary>
        /// <param name="emailAdress"> - адресс электронной почты (и отправителя, и получателя)</param>
        /// <param name="password"> - пароль от учетной записи почты</param>
        /// <param name="name">Имя(заголовок), которое будет напечатано как название письма</param>
        public MailController(string emailAdress, string password, string name)
        {
            // адрес отправителя, имя(заголовок), которое будет напечатано как название письма
            from = new MailAddress(emailAdress, name);

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

        /// <summary>
        /// Отправка сообщения message c заголовком subject на эл. адрес receiver
        /// </summary>
        /// <param name="receiver">адрес получателя</param>
        /// <param name="message">текст письма</param>
        /// <param name="subject">заголовк письма</param>
        public void SendMessageTo(string receiver, string message, string subject)
        {
            // работа с сообщениями 
            MailAddress Receiver = new MailAddress(receiver);
            MailMessage Message = new MailMessage(from, Receiver);
            // Тема
            Message.Subject = subject;
            // Тело сообщения
            Message.Body = message;

            // отправляем сообщение
            client.Send(Message);
        }
    }
}