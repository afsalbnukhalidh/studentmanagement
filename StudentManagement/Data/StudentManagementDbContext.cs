using Microsoft.EntityFrameworkCore;
using StudentManagement.Models.Domain;

namespace StudentManagement.Data
{
	public class StudentManagementDbContext : DbContext
	{
		public StudentManagementDbContext(DbContextOptions options) : base(options)
		{
		}
		public DbSet<Standard> Standards { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
	}
}
