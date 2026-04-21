using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace SistemaLogin.Services
{
    public class EmailService
    {
        public void EnviarCodigo(string emailDestino, int codigo)
        {
            try
            {
                MailMessage mensagem = new MailMessage();

                mensagem.From = new MailAddress("seuemail@gmail.com");
                mensagem.To.Add(emailDestino);

                mensagem.Subject = "Código de recuperação de senha";

                mensagem.Body = "Seu código de recuperação é: " + codigo;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.Credentials = new NetworkCredential("wwluiz123@gmail.com", "yeydborthelfpoks");

                smtp.EnableSsl = true;

                smtp.Send(mensagem);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar email: " + ex.Message);
            }
        }
    }
}