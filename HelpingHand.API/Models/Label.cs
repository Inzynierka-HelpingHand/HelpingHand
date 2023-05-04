using System.ComponentModel.DataAnnotations;

namespace HelpingHand.API.Models
{
	public class Label
	{
		[Key]
		public int Id { get; set; }
		[StringLength(50)]
		public string? Name { get; set; }
		public ICollection<Ticket>? Tickets { get; set; }
	}
}
