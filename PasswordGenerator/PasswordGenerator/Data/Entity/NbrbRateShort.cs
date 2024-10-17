using System.ComponentModel.DataAnnotations;

namespace PasswordGenerator.Data.Entity
{
    public class NbrbRateShort
    {
        public int Cur_ID { get; set; }
        [Key]
        public System.DateTime Date { get; set; }
        public decimal? Cur_OfficialRate { get; set; }
    }
}
