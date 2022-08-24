using System.ComponentModel.DataAnnotations;

namespace BankAPI2.Model
{
    public class CardRequest
    {
        [Key]
        public int Id { get; set; }

        public string? AccoutNumber { get; set; }

        public CardType CardType { get; set; }

        public string? DeleiveryAddress { get; set; }

        public string? Status { get; set; }


      


    }

    public enum CardType
    {
        Mastercard,
        Visa,
        VisaGold
    }
}
