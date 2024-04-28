namespace WpfApp1.Models;

public class MaterialGroup
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<MaterialSubgroup> MaterialSubgroups { get; } = [];
}