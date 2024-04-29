namespace WpfApp1.Models;

public class TechnologyProcess
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Principles { get; set; }
    public float? ReadyPercentage { get; set; }
    
    public List<ParameterValue> ParameterValues { get; } = [];
    public List<Prefix> Prefixes { get; } = [];
    public List<Technology> Technologies { get; } = [];
}