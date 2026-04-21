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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
      "Deseja sair da conta?",
      "Confirmação",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question
  );

            if (resultado == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
