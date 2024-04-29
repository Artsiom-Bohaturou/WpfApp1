namespace WpfApp1.Models;

public class Parameter
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Symbol { get; set; }
    public string ShortName { get; set; }
    public string Type { get; set; }
    public string CodeForConnection { get; set; }
    public int? ConnectionTypeId { get; set; }
    public int? ExportId { get; set; }
    public string TypeDate { get; set; }
    public int? Hidden { get; set; }
    public int? Initialize { get; set; }
    public string Formula { get; set; }
    public string Description { get; set; }
    public float? ReadyPercentage { get; set; }
    
    public virtual ConnectionType ConnectionType { get; set; }
    public virtual Export Export { get; set; }
    
    public List<Technology> Technologies { get; } = [];
    public List<ParameterGroup> ParameterGroup { get; } = [];
}