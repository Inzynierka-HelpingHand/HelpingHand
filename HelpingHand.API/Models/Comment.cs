using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpingHand.API.Models
{
	public class Comment
	{
		[Key]
		public int Id { get; set; }
		[StringLength(1000)]
		public string? Text { get; set; }
		[ForeignKey("Author")]
		public string? AuthorId { get; set; }
		public User? Author { get; set; } 
		[ForeignKey("Address")]
		public int TicketId { get; set; }
		public Ticket? Ticket { get; set; }
		public DateTime? CreatedDate { get; set; }
	}
}
