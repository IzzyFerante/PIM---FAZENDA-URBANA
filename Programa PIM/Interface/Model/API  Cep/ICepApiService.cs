using Refit;

namespace Testes
{
    internal interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<WebResponse> GetAddressAsync(string cep);
    }
}
