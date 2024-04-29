namespace WpfApp1.Models;

public class MeasurementUnit
{
    public int Id { get; set; }
    public string Symbol { get; set; }
    public string ShortName { get; set; }
    public string Name { get; set; }
    
    public List<MeasurementUnitGroup> MeasurementUnitGroups { get; } = [];
}