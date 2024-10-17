using PasswordGenerator.Data.Entity;

namespace PasswordGenerator.Services.Interface
{
    public interface ICurrencyService
    {
        Task<NbrbRate> GetExchangeRateAsync(string sourceCurrency, string destinationCurrency);
    }
}
