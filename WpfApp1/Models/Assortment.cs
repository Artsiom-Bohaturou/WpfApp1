namespace WpfApp1.Models;

public class Assortment
{
    public int Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public string Slide3DFilePath { get; set; }
    public string Slide2DFilePath { get; set; }
    public string SlideXYZFilePath { get; set; }
    public float? ReadyPercentage { get; set; }

    public List<ParameterValue> ParameterValues { get; } = [];
    public List<AssortmentRoll> AssortmentRolls { get; } = [];
    public List<Material> Materials { get; } = [];
}