using BlazorWebServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorWebServer.DataAccess
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAllAuthors();
    }
}