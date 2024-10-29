using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ShopStore.Shared.Models;
using ShopStore.Shared.Models.DTO;
using System.Collections.Generic;

namespace ShopStore.Client.Services
{
    public class ShoppingCartService
    {
        private readonly HttpClient _httpClient;

        public ShoppingCartService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ShoppingCart>> GetShoppingCartsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<ShoppingCart>>("api/ShoppingCarts");
        }

        public async Task<ShoppingCartDTO> GetShoppingCartByIdAsync(int id)
        {
            var shoppingCart = await _httpClient.GetFromJsonAsync<ShoppingCart>($"api/ShoppingCarts/{id}");
            return MapToDTO(shoppingCart);
        }

        private ShoppingCartDTO MapToDTO(ShoppingCart shoppingCart)
        {
            if (shoppingCart == null) return null;

            return new ShoppingCartDTO
            {
                ShoppingCartId = shoppingCart.ShoppingCartId,
                CreatedDate = shoppingCart.CreatedDate,
                CustomerId = shoppingCart.CustomerId,
                CartItems = shoppingCart.CartItems?.Select(ci => new CartItemDTO
                {
                    CartItemId = ci.CartItemId,
                    Quantity = ci.Quantity,
                    ProductId = ci.ProductId
                }).ToList()
            };
        }


        public async Task<ShoppingCart> CreateShoppingCartAsync(ShoppingCartDTO shoppingCartDTO)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ShoppingCarts", shoppingCartDTO);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ShoppingCart>();
        }

        public async Task<bool> UpdateShoppingCartAsync(int id, ShoppingCartDTO shoppingCartDTO)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/ShoppingCarts/{id}", shoppingCartDTO);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteShoppingCartAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/ShoppingCarts/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
