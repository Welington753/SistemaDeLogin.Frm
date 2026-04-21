using SistemaLogin.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLogin
{
    public partial class FormVerificarCodigo : Form
    {
        int codigoRecebido;
        string emailUsuario;
        DateTime tempoExpiracao;
        public FormVerificarCodigo(int codigo,string email, DateTime expiracao)
        {
            InitializeComponent();
            codigoRecebido = codigo;
            emailUsuario = email;
            tempoExpiracao = expiracao;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string codigoDigitado =
                txtCod1.Text +
                txtCod2.Text +
                txtCod3.Text +
                txtCod4.Text +
                txtCod5.Text +
                txtCod6.Text;

            int codigoDigitadoInt = Convert.ToInt32(codigoDigitado);

            if (codigoDigitado.Length < 6)
            {
                MessageBox.Show("Digite o código completo.");
                return;
            }


            if (DateTime.Now > tempoExpiracao)
            {
                MessageBox.Show("Código expirado.");
                return;
            }

            if (codigoDigitadoInt == codigoRecebido)
            {
                MessageBox.Show("Código correto.");

                FormAlterarSenha tela = new FormAlterarSenha(emailUsuario);
                tela.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Código incorreto.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            codigoRecebido = random.Next(100000, 999999);

            EmailService email = new EmailService();
            email.EnviarCodigo(emailUsuario, codigoRecebido);

            btnReenviar.Enabled = false;

            timerReenvio.Start();

            MessageBox.Show("Novo código enviado para o email.");
        }

        private void timerReenvio_Tick(object sender, EventArgs e)
        {
            btnReenviar.Enabled = true;
            timerReenvio.Stop();
        }

        private void txtCodigo1_TextChanged(object sender, EventArgs e)
        {
            if (txtCod1.Text.Length == 1)
                txtCod2.Focus();
        }

        private void txtCod2_TextChanged(object sender, EventArgs e)
        {
            if (txtCod2.Text.Length == 1)
                txtCod3.Focus();
        }

        private void txtCod3_TextChanged(object sender, EventArgs e)
        {
            if (txtCod3.Text.Length == 1)
                txtCod4.Focus();
        }

        private void txtCod4_TextChanged(object sender, EventArgs e)
        {
            if (txtCod4.Text.Length == 1)
                txtCod5.Focus();
        }

        private void txtCod5_TextChanged(object sender, EventArgs e)
        {
            if (txtCod5.Text.Length == 1)
                txtCod6.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
