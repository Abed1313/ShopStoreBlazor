using ShopStore.Shared.Models;
using ShopStore.Shared.Models.DTO;
using System.Net.Http.Json;

namespace ShopStore.Client.Services
{
    public class OrderItemService
    {
        private readonly HttpClient _httpClient;

        public OrderItemService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET all order items
        public async Task<List<OrderItem>> GetOrderItemsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<OrderItem>>("api/OrderItems");
        }

        // GET a specific order item by ID
        public async Task<OrderItem> GetOrderItemByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<OrderItem>($"api/OrderItems/{id}");
        }

        // POST a new order item
        public async Task<OrderItem> CreateOrderItemAsync(OrderItemDTO orderItemDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/OrderItems", orderItemDto);
            response.EnsureSuccessStatusCode(); // Ensure the request was successful
            return await response.Content.ReadFromJsonAsync<OrderItem>();
        }

        // PUT (update) an existing order item
        public async Task UpdateOrderItemAsync(int id, OrderItemDTO orderItemDto)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/OrderItems/{id}", orderItemDto);
            response.EnsureSuccessStatusCode(); // Ensure the request was successful
        }

        // DELETE an order item
        public async Task DeleteOrderItemAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/OrderItems/{id}");
            response.EnsureSuccessStatusCode(); // Ensure the request was successful
        }
    }
}
