using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace SistemaLogin.Services
{
    public class CepService
    {
        public dynamic BuscarCep(string cep)
        {
            try
            {
                cep = cep.Replace("-", "").Trim();

                string url = $"https://viacep.com.br/ws/{cep}/json/";

                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();

                using (Stream dataStream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataStream))
                {
                    string json = reader.ReadToEnd();
                    return JsonConvert.DeserializeObject(json);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar CEP: " + ex.Message);
            }
        }
    }
}
