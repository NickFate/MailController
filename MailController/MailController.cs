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


        /// <summary>
        /// Класс для отпраки сообщений
        /// </summary>
        /// <param name="emailAdress"> - адресс электронной почты (и отправителя, и получателя)</param>
        /// <param name="password"> - пароль от учетной записи почты</param>
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


        /// <summary>
        /// Класс для отпраки сообщений
        /// </summary>
        /// <param name="emailAdress"> - адресс электронной почты (и отправителя, и получателя)</param>
        /// <param name="password"> - пароль от учетной записи почты</param>
        /// <param name="name">Имя(заголовок), которое будет напечатано как название письма</param>
        public MailController(string emailAdress, string password, string name)
        {
            // адрес отправителя, имя(заголовок), которое будет напечатано как название письма
            MailAddress from = new MailAddress(emailAdress, name);

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
        /// Отправляет сообщение
        /// </summary>
        /// <param name="message">Текст письма</param>
        /// <param name="subject">Заголовок</param>
        public void SendMessage(string message, string subject)
        {
            // работа с сообщениями 
            
            // Тема
            this.message.Subject = subject;
            // Тело сообщения
            this.message.Body = message;

            // отправляем сообщение
            client.Send(this.message);
        }

        /// <summary>
        /// Отправляет сообщение
        /// </summary>
        /// <param name="message">Текст письма</param>
        public void SendMessage(string message)
        {
            // работа с сообщениями 

            // Тело сообщения
            this.message.Body = message;

            // отправляем сообщение
            client.Send(this.message);
        }

    }
}