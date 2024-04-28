namespace WpfApp1.Models;

public class ParameterValue
{
    public int Id { get; set; }
    public int ParameterId { get; set; }
    public string ParameterStringValue { get; set; }
    public string UnitShortName { get; set; }
    
    public virtual Parameter Parameter { get; set; }
    
    public List<Assortment> Assortments { get; } = [];
    public List<Equipment> Equipments { get; } = [];
    public List<Material> Materials { get; } = [];
    public List<TechnologyProcess> TechnologyProcesses { get; } = [];
    public List<Technology> Technologies { get; } = [];
    public List<Construction> Constructions { get; } = [];
    public List<Prefix> Prefixes { get; } = [];
    public List<Project> Projects { get; } = [];
}