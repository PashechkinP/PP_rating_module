using Microsoft.EntityFrameworkCore;

namespace PP_rating_module

{
	public class ApplicationContext : DbContext
	{
		public DbSet<UserStat> UsersStats { get; set; } = null!;
		
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
		{ }
	}
}
