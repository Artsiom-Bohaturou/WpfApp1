using System.Windows;

namespace WpfApp1.Views;

public partial class EditProjectForm : Window
{
    public EditProjectForm()
    {
        InitializeComponent();
    }

    private void CreateElement(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void HideElement(object sender, RoutedEventArgs e)
    {
        Application.Current.Windows[0].Hide();
    }
}