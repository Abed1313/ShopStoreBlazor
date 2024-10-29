using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ShopStore.Shared.Models;
using ShopStore.Shared.Models.DTO;
using System.Collections.Generic;

namespace ShopStore.Client.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/Products");
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"api/Products/{id}");
        }

        public async Task<Product> CreateProductAsync(ProductDTO productDTO)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Products", productDTO);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Product>();
        }

        public async Task<Product> UpdateProductAsync(int id, ProductDTO productDTO)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Products/{id}", productDTO);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Product>();
        }

        public async Task DeleteProductAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Products/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
