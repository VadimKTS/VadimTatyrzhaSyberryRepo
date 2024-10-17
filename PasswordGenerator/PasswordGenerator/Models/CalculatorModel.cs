namespace PasswordGenerator.Models
{
    public class CalculatorModel
    {
        public string Operation { get; set; }
        public decimal Number1 { get; set; }
        public decimal Number2 { get; set; }
        public decimal Result { get; set; }
        public string Error { get; set; } = string.Empty;
    }
}
