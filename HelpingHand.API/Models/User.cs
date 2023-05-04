using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HelpingHand.API.Models
{
	public class User : IdentityUser
	{
		public ICollection<Licence>? Licences { get; set; }
		[Required]
		public Location? Location { get; set; }
	}
}
