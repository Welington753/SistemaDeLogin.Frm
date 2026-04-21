using MySql.Data.MySqlClient;
using SistemaLogin.Database;
using SistemaLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLogin.Security;



namespace SistemaLogin.Services
{

    public class UsuarioService
    {
        private Conexao _conexao = new Conexao();

        public bool ValidarLogin(string usuario, string senha)
        {
            using (MySqlConnection conn = _conexao.ObterConexao())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND senha = @senha";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                string senhaHash = SenhaHelper.GerarHash(senha);

                cmd.Parameters.AddWithValue("@senha", senhaHash);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                return resultado > 0;
            }
        }

        public bool CadastrarUsuario(Usuario usuario)
        {
            using (MySqlConnection conn = _conexao.ObterConexao())
            {
                conn.Open();

                string query = @"INSERT INTO usuarios 
                                (nome, data_nascimento, cpf, rg, cidade, cep, usuario, senha) 
                                VALUES 
                                (@nome, @dataNascimento, @cpf, @rg, @cidade, @cep, @usuario, @senha)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@dataNascimento", usuario.DataNascimento);
                cmd.Parameters.AddWithValue("@cpf", usuario.CPF);
                cmd.Parameters.AddWithValue("@rg", usuario.RG);
                cmd.Parameters.AddWithValue("@cidade", usuario.Cidade);
                cmd.Parameters.AddWithValue("@cep", usuario.CEP);
                cmd.Parameters.AddWithValue("@usuario", usuario.UsuarioLogin);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool CadastrarUsuario(
        string nome,
        DateTime dataNascimento,
        string cpf,
        string rg,
        string cidade,
        string cep,
        string usuario,
        string senha,
        string email)

        {
            string query = @"INSERT INTO usuarios
    (nome, data_nascimento, cpf, rg, cidade, cep, usuario, senha, email)
    VALUES
    (@nome, @dataNascimento, @cpf, @rg, @cidade, @cep, @usuario, @senha, @email)";

            using (MySqlConnection conn = _conexao.ObterConexao())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Parameters.AddWithValue("@rg", rg);
                cmd.Parameters.AddWithValue("@cidade", cidade);
                cmd.Parameters.AddWithValue("@cep", cep);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                string senhaHash = SenhaHelper.GerarHash(senha);
                cmd.Parameters.AddWithValue("@senha", senhaHash);
                cmd.Parameters.AddWithValue("@email", email);

                int resultado = cmd.ExecuteNonQuery();

                return resultado > 0;
            }
        }

        public bool UsuarioExiste(string usuario)
        {
            using (MySqlConnection conn = _conexao.ObterConexao())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                return resultado > 0;
            }
        }

        public bool CPFExiste(string cpf)
        {
            using (MySqlConnection conn = _conexao.ObterConexao())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM usuarios WHERE cpf = @cpf";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@cpf", cpf);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                return resultado > 0;
            }
        }
        public void EnviarCodigoEmail(string emailDestino, int codigo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("seuemail@gmail.com");
                mail.To.Add(emailDestino);
                mail.Subject = "Código de recuperação de senha";
                mail.Body = "Seu código de verificação é: " + codigo;

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("seuemail@gmail.com", "sua_senha_app");
                smtp.EnableSsl = true;

                smtp.Send(mail);

                MessageBox.Show("Código enviado para seu email!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar email: " + ex.Message);
            }
        }
        public bool AlterarSenha(string email, string novaSenha)
        {
            using (MySqlConnection conn = _conexao.ObterConexao())
            {
                conn.Open();

                string query = "UPDATE usuarios SET senha = @senha WHERE email = @email";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                string senhaHash = SenhaHelper.GerarHash(novaSenha);

                // Adiciona os dois parâmetros
                cmd.Parameters.AddWithValue("@senha", senhaHash);
                cmd.Parameters.AddWithValue("@email", email);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }
}
