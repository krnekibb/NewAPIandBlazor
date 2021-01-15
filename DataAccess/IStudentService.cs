using BlazorWebServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebServer.DataAccess
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();

        Task<Student> GetStudent(int id);
    }
}