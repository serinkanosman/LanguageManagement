using LanguageManagement.Application.Configuration;
using LanguageManagement.Application.DTOs;
using LanguageManagement.Application.Interfaces;
using Microsoft.Extensions.Options;
using System.Text.Json;

namespace LanguageManagement.Infrastructure.Services
{
    public class CultureService : ICultureService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public CultureService(HttpClient httpClient, IOptions<CultureApiSettings> settings)
        {
            _httpClient = httpClient;
            _apiUrl = settings.Value.CultureApiUrl;
        }

        public async Task<List<CultureData>> GetCulturesAsync()
        {
            var response = await _httpClient.GetAsync(_apiUrl);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var root = JsonSerializer.Deserialize<RootResponse>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            });

            return root?.Data ?? new List<CultureData>();
        }

     
    }
}
