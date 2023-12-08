using Library_MAUI_R53.Models;
using Library_MAUI_R53.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Library_MAUI_R53.Services
{
    public class BookService : IGenericService<Book>
    {
        private readonly HttpClient _httpClient;
        public BookService(HttpClient http)
        {
            _httpClient = http;
        }

        private static readonly string BaseUrl = "http://10.0.2.2:5154";

        public async Task<List<Book>> GetAll()
        {
            var books = await _httpClient.GetFromJsonAsync<List<Book>>(BaseUrl + "/api/Book");
           
            return books;
        }

      
        public Task<Book> Create(Book entity)
        {
            throw new NotImplementedException();
        }

        public Task<Book> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> Update(Book entity)
        {
            throw new NotImplementedException();
        }
    }
}
