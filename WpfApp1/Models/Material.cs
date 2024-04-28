namespace WpfApp1.Models;

public class Material
{
    public int Id { get; set; }
    public string Mark { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public float? ReadyPercentage { get; set; }
    
    public List<Equipment> Equipments { get; } = [];
    public List<Assortment> Assortments { get; } = [];
    public List<ParameterValue> ParameterValues { get; } = [];
    public List<MaterialSubgroup> MaterialSubgroups { get; } = [];
}