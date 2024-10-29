using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ShopStore.Shared.Models;
using ShopStore.Shared.Models.DTO;
using System.Collections.Generic;

namespace ShopStore.Client.Services
{
    public class ReviewService
    {
        private readonly HttpClient _httpClient;

        public ReviewService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Review>> GetReviewsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Review>>("api/Reviews");
        }

        public async Task<ReviewDTO> GetReviewByIdAsync(int id)
        {
            var review = await _httpClient.GetFromJsonAsync<Review>($"api/Reviews/{id}");
            if (review == null) return null;

            // Map Review to ReviewDTO
            return new ReviewDTO
            {
                Rating = review.Rating,
                Comment = review.Comment,
                CustomerId = review.CustomerId,
                ProductId = review.ProductId
            };
        }

        public async Task<Review> CreateReviewAsync(ReviewDTO reviewDTO)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Reviews", reviewDTO);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Review>();
        }

        public async Task<bool> UpdateReviewAsync(int id, ReviewDTO reviewDTO)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Reviews/{id}", reviewDTO);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteReviewAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Reviews/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
