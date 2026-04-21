using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string UsuarioLogin { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Email { get; set; }
    }
}
