namespace WpfApp1.Models;

public class ProjectElement
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ShortName { get; set; }
    public int Position { get; set; } = 1;
    public bool IsEditable { get; set; }
    public int BlueprintId { get; set; }
    public int ModelId { get; set; }
    public int BuildId { get; set; }
    
    public Project Project { get; set; }
    public Blueprint Blueprint { get; set; }
    public Model Model { get; set; }
    public Build Build { get; set; }
}