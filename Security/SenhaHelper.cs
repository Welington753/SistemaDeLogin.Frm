using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Security
{
    internal class SenhaHelper
    {
        public static string GerarHash(string senha)
        {
            SHA256 sha = SHA256.Create();

            byte[] bytes = Encoding.UTF8.GetBytes(senha);
            byte[] hash = sha.ComputeHash(bytes);

            StringBuilder resultado = new StringBuilder();

            foreach (byte b in hash)
            {
                resultado.Append(b.ToString("x2"));
            }

            return resultado.ToString();
        }
    }
}
