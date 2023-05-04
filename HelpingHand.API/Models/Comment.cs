namespace HelpingHand.API.Models
{
	public class Comment
	{
		public int Id { get; set; }
		public string? Text { get; set; }
		public User? Author { get; set; } 
		public Ticket? Ticket { get; set; }
	}
}
