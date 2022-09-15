using System.ComponentModel.DataAnnotations;

namespace AECrowd.Models
{
    public class DonateFormModel
    {
        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string? AEAddress { get; set; }

        [Required]
        public int Id { get; set; }
    }
}
