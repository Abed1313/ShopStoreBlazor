using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ShopStore.Shared.Models;
using ShopStore.Shared.Models.DTO;
using System.Collections.Generic;

namespace ShopStore.Client.Services
{
    public class PaymentService
    {
        private readonly HttpClient _httpClient;

        public PaymentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Payment>> GetPaymentsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Payment>>("api/Payments");
        }

        public async Task<Payment> GetPaymentByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Payment>($"api/Payments/{id}");
        }

        public async Task<Payment> CreatePaymentAsync(PaymentDTO paymentDTO)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Payments", paymentDTO);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Payment>();
        }

        public async Task<Payment> UpdatePaymentAsync(int id, PaymentDTO paymentDTO)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Payments/{id}", paymentDTO);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Payment>();
        }

        public async Task DeletePaymentAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Payments/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
