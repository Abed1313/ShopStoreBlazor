using ShopStore.Shared.Models.DTO;
using ShopStore.Shared.Models;
using System.Net.Http.Json;

namespace ShopStore.Client.Services
{
    public class CartItemService
    {
        private readonly HttpClient _httpClient;

        public CartItemService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CartItem>> GetCartItemsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<CartItem>>("api/CartItems");
        }

        public async Task<CartItem> GetCartItemByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<CartItem>($"api/CartItems/{id}");
        }

        public async Task<CartItemDTO> CreateCartItemAsync(CartItemDTO cartItemDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/CartItems", cartItemDto);
            return await response.Content.ReadFromJsonAsync<CartItemDTO>();
        }

        public async Task UpdateCartItemAsync(int id, CartItemDTO cartItemDto)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/CartItems/{id}", cartItemDto);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteCartItemAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/CartItems/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
