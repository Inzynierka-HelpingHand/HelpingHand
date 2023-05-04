using System.ComponentModel.DataAnnotations;

namespace HelpingHand.API.Models
{
	public class Permission
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(100)]
		public string? Name { get; set; }
		[StringLength(250, MinimumLength = 5)]
		public string? Description { get; set; }
	}
}
