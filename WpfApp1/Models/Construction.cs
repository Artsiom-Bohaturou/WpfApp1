namespace WpfApp1.Models;

public class Construction
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
    public string Symbol { get; set; }
    public string Name { get; set; }
    public string SmallPictureFilePath { get; set; }
    public string Picture2DFilePath { get; set; }
    public int? Picture2DCount { get; set; }
    public string Picture3DFilePath { get; set; }
    public string SmallReferenceFilePath { get; set; }
    public string Reference3DFilePath { get; set; }
    public string Reference2DFilePath { get; set; }
    public string ModelXlsFilePath { get; set; }
    public string FormulaXlsFilePath { get; set; }
    public string PositionNumber { get; set; }
    public float? ReadyPercentage { get; set; }

    public virtual Project Project { get; set; }
    
    public List<AnalysisType> AnalysisTypes { get; } = [];
    public List<InstructionPosition> InstructionPositions { get; } = [];
    public List<ParameterValue> ParameterValues { get; } = [];

}