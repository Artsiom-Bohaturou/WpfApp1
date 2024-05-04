using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
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
        
        Projects = new ObservableCollection<Project>(context.Projects);
        
    }
    
    private void bInput_Click(object sender, RoutedEventArgs e)
    {
        
    }
}