using System.ComponentModel.DataAnnotations;

namespace HelpingHand.API.Models
{
	public class Hardwere
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public User? Keeper { get; set; }
	}
}
