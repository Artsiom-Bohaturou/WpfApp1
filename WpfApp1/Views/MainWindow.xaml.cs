using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using WpfApp1.Contexts;
using WpfApp1.Models;

namespace WpfApp1.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public ObservableCollection<Project> Projects { get; set; }
    
    public MainWindow(ApplicationContext context)
    {
        InitializeComponent();
        DataContext = this;
        WindowStartupLocation = WindowStartupLocation.CenterScreen;
        Projects = new ObservableCollection<Project>(context.Projects);
        
        foreach (var project in Projects)
        {
            project.Elements = new ObservableCollection<ProjectElement>(context.ProjectElements.Where(element => element.Project.Id == project.Id));
        }
    }
}