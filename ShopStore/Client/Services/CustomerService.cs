using Azure;
using ShopStore.Shared.Models;
using ShopStore.Shared.Models.DTO;
using System.Net.Http.Json;

namespace ShopStore.Client.Services
{
    public class CustomerService
    {
        private readonly HttpClient _httpClient;

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Customer>> GetCustomersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Customer>>("api/Customers");
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Customer>($"api/Customers/{id}");
        }

        public async Task<Customer> CreateCustomerAsync(CustomerDTO customer)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Customers", customer);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Customer>();
        }
        
        public async Task<Customer> UpdateCustomerAsync(int id, CustomerDTO customer)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Customers/{id}", customer);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Customer>();
        }

        public async Task DeleteCustomerAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Customers/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
