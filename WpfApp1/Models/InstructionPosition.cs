namespace WpfApp1.Models;

public class InstructionPosition
{
    public int Id { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public string SmallPictureFilePath { get; set; }
    public string Picture2DFilePath { get; set; }
    public string Picture3DFilePath { get; set; }
    public string Reference3DFilePath { get; set; }
    public string Reference2DFilePath { get; set; }
    public string ModelXlsFilePath { get; set; }
    public string FormulaXlsFilePath { get; set; }
    
    public List<InstructionGroupPosition> InstructionGroupPositions { get; } = [];
    public List<Construction> Constructions { get; } = [];
}