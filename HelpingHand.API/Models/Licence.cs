using System.ComponentModel.DataAnnotations;

namespace HelpingHand.API.Models
{
	public class Licence
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(50)]
		public string? ProgramName { get; set; }
		[Required]
		[StringLength(50)]
		public string? LicenceType { get; set; }
		public int Cost { get; set; }
		public ICollection<User>? Users { get; set; }
	}
}
