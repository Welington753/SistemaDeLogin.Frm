using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaLogin.Database
{
    public class Conexao
    {
        private string stringConexao =
            "server=localhost;database=sistema_login;user=root;password=3306;";

        public MySqlConnection ObterConexao()
        {
            return new MySqlConnection(stringConexao);
        }
    }
}
