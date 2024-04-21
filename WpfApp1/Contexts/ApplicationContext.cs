using Microsoft.EntityFrameworkCore;
using WpfApp1.Models;

namespace WpfApp1.Contexts;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {
    }

    public DbSet<Project> Projects { get; set; }
    public DbSet<Blueprint> Blueprints { get; set; }
    public DbSet<Build> Builds { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<ProjectElement> ProjectElements { get; set; }
}