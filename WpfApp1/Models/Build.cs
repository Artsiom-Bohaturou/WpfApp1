namespace WpfApp1.Models;

public class Build
{
    public int Id { get; set; }
    public string? Link { get; set; }
    public string? Slide { get; set; }
    
    public ProjectElement ProjectElement { get; set; }
}