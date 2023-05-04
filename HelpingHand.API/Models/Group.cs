﻿using System.ComponentModel.DataAnnotations;

namespace HelpingHand.API.Models
{
	public class Group
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(50)]
		public string? Name { get; set; }
		[Required]
		[StringLength(250)]
		public string? Description { get; set; }
	}
}
