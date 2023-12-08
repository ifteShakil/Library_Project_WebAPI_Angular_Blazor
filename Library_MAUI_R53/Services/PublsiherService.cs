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
    public class PublsiherService : IGenericService<Publisher>
    {
        private readonly HttpClient _httpClient;
        public PublsiherService(HttpClient http)
        {
            _httpClient = http;
        }

        private static readonly string BaseUrl = "http://localhost:5154";

        public async Task<List<Publisher>> GetAll()
        {
            var p = await _httpClient.GetFromJsonAsync<List<Publisher>>(BaseUrl+"/api/Publishers");
            //var response = await p.Content.ReadFromJsonAsync<List<Publisher>>();
            return p;        
        }

        public Task<Publisher> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> Create(Publisher entity)
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> Update(Publisher entity)
        {
            throw new NotImplementedException();
        }
    }
}
