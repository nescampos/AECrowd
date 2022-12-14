using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AECrowd.Data
{
    public class Donation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int CauseId { get; set; }

        [Required]
        public string? UserId { get; set; }

        [Required]
        public string? AEAddress { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        [ForeignKey("CauseId")]
        public Cause? Cause { get; set; }
    }
}
