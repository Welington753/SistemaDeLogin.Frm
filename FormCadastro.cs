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
using SistemaLogin.Security;

namespace SistemaLogin
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioService service = new UsuarioService();

            // capos obrigatorios
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtRg.Text) ||
                string.IsNullOrWhiteSpace(txtCidade.Text) ||
                string.IsNullOrWhiteSpace(txtCep.Text) ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (service.UsuarioExiste(txtUsuario.Text))
            {
                MessageBox.Show("Usuário já existe!");
                return;
            }

            if (service.CPFExiste(txtCpf.Text))
            {
                MessageBox.Show("CPF já cadastrado!");
                return;
            }
            if (!CpfHelper.ValidarCPF(txtCpf.Text))
            {
                MessageBox.Show("CPF inválido!");
                return;
            }
            if (pbForcaSenha.Value < 100)
            {
                MessageBox.Show("A senha não atende todos os requisitos.");
                return;
            }

            bool sucesso = service.CadastrarUsuario(

     txtNome.Text,
     dtpNascimento.Value,
     txtCpf.Text,
     txtRg.Text,
     txtCidade.Text,
     txtCep.Text,
     txtUsuario.Text,
     txtSenha.Text,
     txtEmail.Text
 );


            if (sucesso)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                FormLogin login = new FormLogin();
                login.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário.");
            }
        }
        private void AtualizarForcaSenha()
        {
            string senha = txtSenha.Text;

            bool temMaiuscula = false;
            bool temNumero = false;
            bool temEspecial = false;
            bool temTamanho = senha.Length >= 8;

            foreach (char c in senha)
            {
                if (char.IsUpper(c))
                    temMaiuscula = true;

                if (char.IsDigit(c))
                    temNumero = true;

                if (!char.IsLetterOrDigit(c))
                    temEspecial = true;
            }

            // Atualiza visual dos requisitos
            AtualizarRequisito(lblMaiuscula, temMaiuscula);
            AtualizarRequisito(lblNumero, temNumero);
            AtualizarRequisito(lblEspecial, temEspecial);
            AtualizarRequisito(lblTamanho, temTamanho);

            int pontos = 0;

            if (temMaiuscula) pontos += 25;
            if (temNumero) pontos += 25;
            if (temEspecial) pontos += 25;
            if (temTamanho) pontos += 25;

            pbForcaSenha.Value = Math.Min(pontos, pbForcaSenha.Maximum);
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            AtualizarForcaSenha();
        }
        private void AtualizarRequisito(Label label, bool valido)
        {
            if (valido)
            {
                label.Text = label.Text.Replace("( )", "(✔)");
                label.ForeColor = Color.Green;
            }
            else
            {
                label.Text = label.Text.Replace("(✔)", "( )");
                label.ForeColor = Color.Red;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            CepService cepService = new CepService();

            var endereco = cepService.BuscarCep(txtCep.Text);

            txtRua.Text = endereco.logradouro;
            txtBairro.Text = endereco.bairro;
            txtCidade.Text = endereco.localidade;
            txtEstado.Text = endereco.uf;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
