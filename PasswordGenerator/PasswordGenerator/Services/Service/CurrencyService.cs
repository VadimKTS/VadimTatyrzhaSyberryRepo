using PasswordGenerator.Services.Interface;

namespace PasswordGenerator.Services.Service
{
    public class CurrencyService : ICurrencyService
    {
        public decimal GetExchangeRate(string sourceCurrency, string destinationCurrency)
        {
            // fake course for simplyfy
            if (sourceCurrency == destinationCurrency)
                return 1m;

            return 0.85m;
        }
    }
}
