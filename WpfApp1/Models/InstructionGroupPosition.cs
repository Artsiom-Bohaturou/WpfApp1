namespace WpfApp1.Models;

public class InstructionGroupPosition
{
    public int Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    
    public List<InstructionPosition> InstructionPositions { get; } = [];
}