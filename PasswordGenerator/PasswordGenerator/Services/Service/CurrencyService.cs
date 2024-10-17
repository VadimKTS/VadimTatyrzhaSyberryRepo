using PasswordGenerator.Data.Entity;
using PasswordGenerator.Services.Interface;
using System.Net.Http.Json;

namespace PasswordGenerator.Services.Service
{
    public class CurrencyService : ICurrencyService
    {
        private readonly HttpClient _httpClient;
        public CurrencyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<NbrbRate> GetExchangeRateAsync(string sourceCurrency, string destinationCurrency)
        {
            // fake course for simplyfy
            //if (sourceCurrency == destinationCurrency)
            //    return 1m;

            //return 0.85m;
            try
            {
                var respose = await _httpClient.GetFromJsonAsync<NbrbRate>($"https://api.nbrb.by/exrates/rates/{destinationCurrency}?parammode=2");
                return respose;
            }
            catch (Exception ex)
            {
                var respone = new NbrbRate() { errorMessage = ex.Message };
                return respone;
            }
        }
    }
}
