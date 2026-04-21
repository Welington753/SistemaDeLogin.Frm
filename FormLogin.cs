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
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;


namespace SistemaLogin
{
    public partial class FormLogin : Form
    {

        bool senhaVisivel = false;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);


        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            btnEntrar.Region = System.Drawing.Region.FromHrgn(
 CreateRoundRectRgn(0, 0, btnEntrar.Width, btnEntrar.Height, 10, 10));

            if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            UsuarioService service = new UsuarioService();

            bool loginValido = service.ValidarLogin(
                txtUsuario.Text,
                txtSenha.Text
            );

            if (loginValido)
            {
                FormPrincipal tela = new FormPrincipal();
                tela.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCadastro telaCadastro = new FormCadastro();
            telaCadastro.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEsqueciSenha tela = new FormEsqueciSenha();
            tela.Show();

            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(btnEntrar.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(btnEntrar.Width - 20, btnEntrar.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, btnEntrar.Height - 20, 20, 20, 90, 90);
            path.CloseAllFigures();

            btnEntrar.Region = new Region(path);


            txtUsuario.Text = "Usuário";
            txtUsuario.ForeColor = Color.Gray;

            txtSenha.Text = "Senha";
            txtSenha.ForeColor = Color.Gray;
            txtSenha.UseSystemPasswordChar = false;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuário";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Gray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void iconMostrarSenha_Click(object sender, EventArgs e)
        {
            if (senhaVisivel)
            {
                txtSenha.UseSystemPasswordChar = true;
                senhaVisivel = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = false;
                senhaVisivel = true;
            }
        }

        private void panelEsquerda_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(
    panelEsquerda.ClientRectangle,
    Color.FromArgb(43, 95, 217),
    Color.FromArgb(90, 141, 238),
    LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(brush, panelEsquerda.ClientRectangle);
        }
    }
}
