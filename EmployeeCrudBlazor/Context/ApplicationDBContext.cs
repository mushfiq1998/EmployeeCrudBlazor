using EmployeeCrudBlazor.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrudBlazor.Context
{
	public class ApplicationDBContext : DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) 
		{ 

		}

		public DbSet<Employee> Employees { get; set; }

	}
}
