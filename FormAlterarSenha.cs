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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaLogin
{
    public partial class FormAlterarSenha : Form
    {
        UsuarioService service = new UsuarioService();
        string emailUsuario;
        bool mostrarSenha = false;


        public FormAlterarSenha(string email)
        {
            InitializeComponent();
            emailUsuario = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }

            bool alterado = service.AlterarSenha(emailUsuario, txtNovaSenha.Text.Trim());

            if (alterado)
            {
                MessageBox.Show("Senha alterada com sucesso!");

                FormLogin tela = new FormLogin();

                tela.Show();

                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNovaSenha_Enter(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == "Nova Senha")
            {
                txtNovaSenha.Text = "";
                txtNovaSenha.ForeColor = Color.Black;
                txtNovaSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtNovaSenha_Leave(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == "")
            {
                txtNovaSenha.Text = "Nova Senha";
                txtNovaSenha.ForeColor = Color.Gray;
                txtNovaSenha.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmarSenha_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text == "Confirmar Senha")
            {
                txtConfirmarSenha.Text = "";
                txtConfirmarSenha.ForeColor = Color.Black;
                txtConfirmarSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmarSenha_Leave(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.Text == "")
            {
                txtConfirmarSenha.Text = "Confirmar Senha";
                txtConfirmarSenha.ForeColor = Color.Gray;
                txtConfirmarSenha.UseSystemPasswordChar = false;
            }
        }

        private void iconMostrarSenha1_Click(object sender, EventArgs e)
        {
            mostrarSenha = !mostrarSenha;

            txtNovaSenha.UseSystemPasswordChar = !mostrarSenha;
            txtConfirmarSenha.UseSystemPasswordChar = !mostrarSenha;
        }
    }
}
