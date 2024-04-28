namespace WpfApp1.Models;

public class ConstructionIncidence
{
    public int Id { get; set; }
    public int ConstructionId { get; set; }
    public int? Sequence { get; set; }
    public int Applicability { get; set; }

    public virtual Construction Construction { get; set; }
}