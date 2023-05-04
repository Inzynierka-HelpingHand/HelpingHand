using System.ComponentModel.DataAnnotations;

namespace HelpingHand.API.Models
{
    public class ComplexityTypes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        public ICollection<Ticket>? Tickets { get; set; }

    }
}
