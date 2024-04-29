namespace WpfApp1.Models;

public class MaterialSubgroup
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<MaterialGroup> MaterialGroups { get; } = [];
    public List<Material> Materials { get; } = [];
}