using BlazorWebServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebServer.DataAccess
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBooks();
    }
}
