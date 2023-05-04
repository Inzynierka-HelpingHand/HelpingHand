using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace HelpingHand.API.Models
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public class Ticket
	{
		[Key]
		public int Id { get; set; }
		[StringLength(100)]
		public string? Title { get; set; }
		[StringLength(2500)]
		public string? Description { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? UpdatedDate { get; set; }
		public ICollection<Comment> Comments { get; set; }
		[ForeignKey("Author")]
		public string? AuthorId { get; set; }
		public User? Author { get; set; }
		[ForeignKey("Assignee")]
		public string? AssigneeId { get; set; }
		public User? Assignee { get; set; }
		[ForeignKey("Status")]
		public int? StatusId { get; set; }
		public TicketStatus? Status { get; set; }
		public ICollection<Label> Labels { get; set; }
		public ComplexityTypes Complexity { get; set; }
		public bool IsUrgent { get; set; } = false;
		[AllowNull]
		public Hardwere Hardwere { get; set; }
		[AllowNull]
		public Licence Licence { get; set; }
	}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
}
