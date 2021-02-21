using BlazorWebServer.DataAccess;
using BlazorWebServer.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWebServer.Pages
{
    public class DisplayBase : ComponentBase
    {
       
        [Inject]
        public IAuthorService AuthorService { get; set; }

        [Inject]
        public IBookService BookService { get; set; }

        public List<Book> Books { get; set; }
       
        public List<Author> Authors { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Authors = (await AuthorService.GetAllAuthors()).ToList();
            Books = (await BookService.GetAllBooks()).ToList();
        }
    }
}
