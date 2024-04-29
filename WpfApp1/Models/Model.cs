namespace WpfApp1.Models;

public class Model
{
    public int Id { get; set; }
    public string? Link { get; set; }
    public string? Slide { get; set; }
    public string? Name { get; set; }
    public string? ShortName { get; set; }
    
    public ProjectElement ProjectElement { get; set; }
}