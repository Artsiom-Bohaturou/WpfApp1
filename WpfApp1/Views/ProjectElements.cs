using System.Windows;
using System.Windows.Controls;

namespace WpfApp1.Views;

public partial class ProjectElements
{

    private void bInputHandler(object sender, RoutedEventArgs e)
    {
        NewProjectWindow window = new NewProjectWindow();
        window.Show();
    }
}