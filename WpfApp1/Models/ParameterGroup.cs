namespace WpfApp1.Models;

public class ParameterGroup
{
    public int Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    
    public List<Parameter> Parameters { get; } = [];
}