namespace WpfApp1.Models;

public class MeasurementUnitGroup
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<MeasurementUnit> MeasurementUnits { get; } = [];
}