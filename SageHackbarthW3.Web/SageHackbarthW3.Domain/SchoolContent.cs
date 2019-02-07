using SageHackbarthW3.Domain.Entities;
using System.Data.Entity;

namespace SageHackbarthW3.Domain
{
	public class SchoolContent : DbContext
	{
		public DbSet<Student> Students { get; set; }
	}
}
