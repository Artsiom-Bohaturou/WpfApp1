namespace WpfApp1.Models;

public class AnalysisType
{
    public int Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public string ExecutableFilePath { get; set; }
    public string Parameters { get; set; }

    public List<Construction> Constructions { get; } = [];

}