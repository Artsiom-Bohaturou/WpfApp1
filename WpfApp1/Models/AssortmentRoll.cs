namespace WpfApp1.Models;

public class AssortmentRoll
{
    public int Id { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    
    public List<Assortment> Assortments { get; } = [];
}