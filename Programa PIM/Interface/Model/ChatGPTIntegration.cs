using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Model
{
    public class ChatGPTIntegration
    {

        private readonly string apiKey = "sk-proj-Q6clh5R195wjAhXwPSTZT3BlbkFJEcFWZZMAbWFMPspIAVLS";

        public async Task<string> GetChatGPTResponse(string prompt)
        {
            if (!ÉPerguntaRelacionadaAoTema(prompt))
            {
                return "Desculpe, não posso te ajudar com isso.\n\nEu posso te ajudar com questões referente a plantações e cultivos em fazendas urbanas nas regiões do Brasil e estações do ano.";
            }


            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                var data = new
                {
                    model = "gpt-3.5-turbo",
                    messages = new[]
                    {
            new { role = "user", content = prompt }
        }
                };

                var response = await client.PostAsJsonAsync("https://api.openai.com/v1/chat/completions", data);

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    return Newtonsoft.Json.Linq.JObject.Parse(responseBody)["choices"][0]["message"]["content"].ToString();
                }
                else
                {
                    return "Failed to get response from ChatGPT API\n";
                }
            }
        }


        private bool ÉPerguntaRelacionadaAoTema(string pergunta)
        {
            var palavrasChave = new[] { "plantação", "cultivo", "fazenda urbana", "Brasil", "estações", "verão", "inverno", "outono", "primavera", "região", "regiões", "semente", "fruto", "clima", "terra", "plantações", "frio", "frias", "quentes", "cidade", "estado" };

            foreach (var palavraChave in palavrasChave)
            {
                if (pergunta.ToLower().Contains(palavraChave.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
