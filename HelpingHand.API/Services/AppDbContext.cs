using HelpingHand.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HelpingHand.API.Services
{
    public class AppDbContext : IdentityDbContext<User>
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
            
        }
		

		public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<TicketStatus> TicketStatuses { get; set; }
        public DbSet<Label> Labels { get; set; }
    }

	public class AppDbContextContextFactory : IDesignTimeDbContextFactory<AppDbContext>
	{
		public AppDbContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-BCP5ROL\\SQLPROJECT;Initial Catalog=Temp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

			return new AppDbContext(optionsBuilder.Options);
		}
	}
}
