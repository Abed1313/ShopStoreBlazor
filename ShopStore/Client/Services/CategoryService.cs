using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ShopStore.Shared.Models;
using ShopStore.Shared.Models.DTO;
using System.Collections.Generic;
using ShopStore.Shared;

namespace ShopStore.Client.Services
{
    public class CategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Category>>("api/Category");
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Category>($"api/Category/{id}");
        }

        public async Task<Category> CreateCategoryAsync(CategoryDTO categoryDTO)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Category", categoryDTO);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Category>();
        }

        public async Task<Category> UpdateCategoryAsync(int id, CategoryDTO categoryDTO)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Category/{id}", categoryDTO);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Category>();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Category/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
