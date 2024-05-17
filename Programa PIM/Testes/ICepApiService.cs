﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    internal interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<WebResponse> GetAddressAsync(string cep);
    }
}
