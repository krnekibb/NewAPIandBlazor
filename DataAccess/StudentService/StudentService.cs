using BlazorWebServer.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWebServer.DataAccess
{
    public class StudentService : IStudentService
    {
        private readonly HttpClient httpClient;

        public StudentService(HttpClient httpClient) 
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await httpClient.GetJsonAsync<Student[]>("api/Student");
        }

        public async Task<Student> GetStudent(int id)
        {
            return await httpClient.GetJsonAsync<Student>($"api/Student/{id}");
        }

        public async Task<Student> CreateStudent(Student newStudent)
        {
            return await httpClient.PostJsonAsync<Student>("api/Student", newStudent);
        }
    }
}
