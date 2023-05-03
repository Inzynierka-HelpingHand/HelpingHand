using HelpingHand.API.Controllers.Interfaces;
using HelpingHand.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelpingHand.API.Controllers
{
	public class TicketController : ITicketController
	{
		private readonly ILogger<TicketController> _logger;

		public TicketController(ILogger<TicketController> logger)
        {
			_logger = logger;
		}
        public Ticket GetTicketById(int id)
		{
			return new Ticket() { 
				Id = id,
				Title = "title"
			};
		}
	}
}
//7105