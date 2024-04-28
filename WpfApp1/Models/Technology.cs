namespace WpfApp1.Models;

public class Technology
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Category { get; set; }
    public string Principles { get; set; }
    public float? ReadyPercentage { get; set; }
    
    public List<TechnologyProcess> TechnologyProcesses { get; } = [];
    public List<ParameterValue> ParameterValues { get; } = [];
}