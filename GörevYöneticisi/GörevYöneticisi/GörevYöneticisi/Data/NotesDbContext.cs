using GörevYöneticisi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace GörevYöneticisi.Data
{
	public class NotesDbContext : DbContext
	{
		public NotesDbContext(DbContextOptions options) : base(options)
		{

		}

		public DbSet<Note> Notes { get; set; }

	}
}
