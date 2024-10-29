using ShopStore.Shared.Models.DTO;
using ShopStore.Shared.Models;
using System.Net.Http.Json;

namespace ShopStore.Client.Services
{
    public class OrderService
    {
        private readonly HttpClient _httpClient;

        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Order>> GetOrdersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Order>>("api/Orders");
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Order>($"api/Orders/{id}");
        }

        public async Task<Order> CreateOrderAsync(OrderDTO orderDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Orders", orderDto);
            return await response.Content.ReadFromJsonAsync<Order>();
        }

        public async Task UpdateOrderAsync(int id, OrderDTO orderDto)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Orders/{id}", orderDto);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteOrderAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Orders/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
