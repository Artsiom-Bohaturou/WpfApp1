using System.Collections.ObjectModel;

namespace WpfApp1.Models;

public class Project
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Position { get; set; } = 1;
    
    public virtual ObservableCollection<ProjectElement> Elements { get; private set; } = new ObservableCollection<ProjectElement>();
    
}