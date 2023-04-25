using System.Diagnostics.CodeAnalysis;

namespace HelpingHand.API.Models
{
	[ExcludeFromCodeCoverage]
	public class Ticket
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public string? Description { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
