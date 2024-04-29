namespace WpfApp1.Models;

public class Prefix
{
    public int PrefixId { get; set; }
    public int? PrefixNumber { get; set; }
    public string PrefixText { get; set; }
    public float? ReadyPercentage { get; set; }
    
    public List<TechnologyProcess> TechnologyProcesses { get; } = [];
    public List<ParameterValue> ParameterValues { get; } = [];
}