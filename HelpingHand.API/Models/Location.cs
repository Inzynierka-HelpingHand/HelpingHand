using System.ComponentModel.DataAnnotations;

namespace HelpingHand.API.Models
{
	public class Location
	{
		[Key]
		public int Id { get; set; }
		/// <summary>
		/// Country name in english 
		/// </summary>
		[Required]
		[StringLength(100)]
		public string? Name { get; set; }
		/// <summary>
		/// Country code in ISO 3166-1 alpha-3 standard
		/// </summary>
		[Required]
		[StringLength(3, MinimumLength = 3)]
		public string? CountryCode { get; set; }
	}
}
