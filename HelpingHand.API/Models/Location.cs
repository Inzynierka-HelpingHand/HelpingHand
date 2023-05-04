using System.ComponentModel.DataAnnotations;

namespace HelpingHand.API.Models
{
	public class Location
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string? Name { get; set; }
	}
}
