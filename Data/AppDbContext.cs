using Microsoft.EntityFrameworkCore;
using WinFormsCRUD.Models;

namespace WinFormsCRUD.Data;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{
	}

	public DbSet<Pessoa> Pessoas { get; set; }
}