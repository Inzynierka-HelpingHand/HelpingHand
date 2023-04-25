using HelpingHand.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpingHand.API.Controllers.Interfaces
{
	public interface ITicketController
	{
		Ticket GetTicketById(int id);

	}
}
