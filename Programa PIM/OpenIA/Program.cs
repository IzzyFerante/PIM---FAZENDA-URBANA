using OpenAI_API;
using System;
using System.Threading.Tasks;


namespace FazendaUrbana
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Substitua pela sua chave de API
            var apiKey = "sk-proj-Q6clh5R195wjAhXwPSTZT3BlbkFJEcFWZZMAbWFMPspIAVLS";
            var openAIAPI = new OpenAIAPI(apiKey);

            Console.WriteLine("Digite sua pergunta:");
            string pergunta = Console.ReadLine();

            string resposta = await ObterRespostaDoChatbot(openAIAPI, pergunta);
            Console.WriteLine("Resposta do Chatbot: " + resposta);
        }

        static async Task<string> ObterRespostaDoChatbot(OpenAIAPI api, string pergunta)
        {
            var result = await api.Completions.CreateCompletionAsync(new OpenAI_API.Completions.CompletionRequest
            {
                Prompt = pergunta,
                MaxTokens = 150
            });


            return result.Completions[0].Text.Trim();
        }
    }
}
