using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaLogin.Services;

namespace SistemaLogin
{
   
    public partial class FormEsqueciSenha : Form
    {
        public static DateTime tempoExpiracao;
        public static int codigoGerado;

        UsuarioService service = new UsuarioService();
        public FormEsqueciSenha()
        {
            InitializeComponent();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random random = new Random();

            codigoGerado = random.Next(100000, 999999);

            tempoExpiracao = DateTime.Now.AddMinutes(5);

            EmailService email = new EmailService();

            email.EnviarCodigo(txtEmail.Text, codigoGerado);

            MessageBox.Show("Código enviado para seu email.");

            FormVerificarCodigo tela = new FormVerificarCodigo(codigoGerado, txtEmail.Text, tempoExpiracao);

            tela.Show();

            this.Hide();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Usuário";
                txtEmail.ForeColor = Color.Gray;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Usuário")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
