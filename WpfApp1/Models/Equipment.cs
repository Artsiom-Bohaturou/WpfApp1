namespace WpfApp1.Models;

public class Equipment
{
    public int Id { get; set; }
    public string Model { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public string SlideFilePath { get; set; }
    public float? ReadyPercentage { get; set; }
    
    public List<Material> Materials { get; } = [];
    public List<ParameterValue> ParameterValues { get; } = [];
    public List<TechnologyProcess> TechnologyProcesses { get; } = [];
}