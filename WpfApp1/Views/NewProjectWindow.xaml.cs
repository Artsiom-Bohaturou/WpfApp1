using System.Windows;
using WpfApp1.Models;

namespace WpfApp1.Views;

public partial class NewProjectWindow : Window
{
    public NewProjectWindow()
    {
        InitializeComponent();
        DataContext = new Project();
    }

    private void CreateProject(object sender, RoutedEventArgs e)
    {
        
    }

    private void HideWindow(object sender, RoutedEventArgs e)
    {
        Application.Current.Windows[0].Hide();
    }
}