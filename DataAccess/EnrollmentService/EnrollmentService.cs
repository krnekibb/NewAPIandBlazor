using BlazorWebServer.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWebServer.DataAccess
{
    public class EnrollmentService : IEnrollmentService
    {
        private readonly HttpClient httpClient;

        public EnrollmentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Enrollment>> GetAllEnrollments()
        {
            return await httpClient.GetJsonAsync<Enrollment[]>("api/Enrollment");
        }

        public async Task<IEnumerable<Enrollment>> GetEnrollmentBySID(int id)
        {
            return await httpClient.GetJsonAsync<Enrollment[]>($"api/Enrollment/studentid/{id}");
        }
    }
}
