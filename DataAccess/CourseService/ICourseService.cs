using BlazorWebServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebServer.DataAccess
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllCourses();
    }
}