using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Views;

public partial class ProjectElements
{
    private int selectedType = 0;

    public ProjectElements()
    {
        InitializeComponent();
    }

    private void bInputHandler(object sender, RoutedEventArgs e)
    {
        Window newWindow;
        if (selectedType == 1)
        {
            newWindow = new NewProjectWindow();
        }
        else if (selectedType == 2)
        {
            newWindow = new EditProjectForm();
        }
        else
        {
            return;
        }

        newWindow.ShowInTaskbar = false;
        newWindow.Show();
        selectedType = 0;
    }

    private void projectClickListener(object sender, RoutedEventArgs e)
    {
        selectedType = 1;
    }

    private void projectElementClickListener(object sender, RoutedEventArgs e)
    {
        selectedType = 2;
    }
}