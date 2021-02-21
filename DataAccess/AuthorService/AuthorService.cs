using BlazorWebServer.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWebServer.DataAccess
{
    public class AuthorService : IAuthorService
    {
        private readonly HttpClient httpClient;

        public AuthorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task <IEnumerable<Author>> GetAllAuthors()
        {
            return await httpClient.GetJsonAsync<Author[]>("api/Authors");
        }
    }
}
