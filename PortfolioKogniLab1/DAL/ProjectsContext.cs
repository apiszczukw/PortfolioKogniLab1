using Microsoft.EntityFrameworkCore;
using PortfolioKogniLab1.Models;

namespace PortfolioKogniLab1.DAL
{
    public class ProjectsContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public ProjectsContext(DbContextOptions options) : base(options)
        {
        }
    }
}
