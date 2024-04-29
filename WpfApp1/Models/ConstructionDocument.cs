namespace WpfApp1.Models;

public class ConstructionDocument
{
    public int Id { get; set; }
    public int ConstructionId { get; set; }
    public int SequenceNumber { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public string Note { get; set; }

    public virtual Construction Construction { get; set; }
}