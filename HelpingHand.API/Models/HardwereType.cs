using System.ComponentModel.DataAnnotations;

namespace HelpingHand.API.Models
{
	public class HardwereType
	{
		[Key] 
		public int Id { get; set; }
		[Required]
		[StringLength(200)]
		public string? Name { get; set; }
		[Required]
		[StringLength(5000)]
		public string? DescriptionJson { get; set; }
	}
}
