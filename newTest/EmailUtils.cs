using System.Net;
using System.Net.Mail;

namespace newTest
{
    internal class EmailUtils
    {
        public static int SendMessage(string to)
        {
            Random r = new Random();
            int random = r.Next(100, 1000);

            using (MailMessage message = new MailMessage("siliciodehefesto@gmail.com", to))
            {
                string MessageBody = @"
                <html>
                <head>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <style>
                    body { font-family: Arial, sans-serif; color: rgb(43, 59, 85); }
                    .content { width: 50%; height: fit-content; padding: 20px; border: 30px solid rgb(43, 59, 85); color: rgb(43, 59, 85); }
                    h1 { color: rgb(211, 179, 122); font-size: 30px; margin-bottom: 0; }
                    p { color: #333333; font-size: 16px; }
                    a { color: rgb(211, 179, 122); }
                    .randomNumber { width: 100%; box-sizing: border-box; padding: 20px; background: rgb(43, 59, 85); text-align: center; color: #fff; }

                    @media screen and (max-width: 500px) {
                        .content { width: 100%; box-sizing: border-box; }
                    }
                </style>
                </head>
                <body>
                    <div class='content'>
                        <h1>Recuperação de Senha</h1>
                        <p style='font-size: 13px; margin-top: 0;'>Não foi você que enviou esta solicitação? Ignore a mensagem!</p>
                        <h2 style='font-size: 30px; width: 100%; text-align: center; margin-bottom: 0;'>Esqueceu sua senha?</h2>
                        <p style='width: 100%; text-align: center; margin-top: 0;'>Caro cliente, para redefinir sua senha, use o código a seguir:</p>
                        <p class='randomNumber' style='font-size: 24px; font-weight: bold;'>" + random + @"</p>
                        <p>Para mais informações, entre em contato <a href='mailto:siliciodehefesto@gmail.com'>através do email</a></p>
                    </div>
                </body>
                </html>
                ";

                message.Subject = "Recuperação de Senha";
                message.Body = MessageBody;
                message.IsBodyHtml = true;

                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587)) 
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("siliciodehefesto@gmail.com", "cuyequxfwoevkkgj");
                    client.Send(message);
                }
            }

            return random;
        }
    }
}
