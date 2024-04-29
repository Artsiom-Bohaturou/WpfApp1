using Marques.EFCore.SnakeCase;
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
    
    public DbSet<AnalysisType> AnalysisTypes { get; set; }
    public DbSet<Assortment> Assortments { get; set; }
    public DbSet<AssortmentRoll> AssortmentRolls { get; set; }
    public DbSet<ConnectionType> ConnectionTypes { get; set; }
    public DbSet<Construction> Constructions { get; set; }
    public DbSet<ConstructionDocument> ConstructionDocuments { get; set; }
    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<Export> Exports { get; set; }
    public DbSet<InstructionGroupPosition> InstructionGroupPositions { get; set; }
    public DbSet<InstructionPosition> InstructionPositions { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<MaterialGroup> MaterialGroups { get; set; }
    public DbSet<MaterialSubgroup> MaterialSubgroups { get; set; }
    public DbSet<MeasurementUnit> MeasurementUnits { get; set; }
    public DbSet<MeasurementUnitGroup> MeasurementUnitGroups { get; set; }
    public DbSet<Parameter> Parameters { get; set; }
    public DbSet<ParameterValue> ParameterValues { get; set; }
    public DbSet<Prefix> Prefixes { get; set; }
    public DbSet<Technology> Technologies { get; set; }
    public DbSet<TechnologyProcess> TechnologyProcesses { get; set; }
    public DbSet<ConstructionIncidence> ConstructionIncidences { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ToSnakeCase();
    }
}