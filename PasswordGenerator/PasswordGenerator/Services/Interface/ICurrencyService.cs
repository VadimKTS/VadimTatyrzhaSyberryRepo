namespace PasswordGenerator.Services.Interface
{
    public interface ICurrencyService
    {
        decimal GetExchangeRate(string sourceCurrency, string destinationCurrency);
    }
}
