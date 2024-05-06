using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Views;

public partial class ProjectElements
{
    private Boolean isSelected = false;
    
    public ProjectElements()
    {
        InitializeComponent();
    }

    private void bInputHandler(object sender, RoutedEventArgs e)
    {

        if (isSelected)
        {
            NewProjectWindow newWindow = new NewProjectWindow();
            newWindow.Show();
            isSelected = false;
        }
    }

    private void tvSelectedListener(object sender, RoutedEventArgs e)
    {
        isSelected = true;
    }
}