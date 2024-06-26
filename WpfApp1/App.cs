using System.Windows;
using WpfApp1.Views;

namespace WpfApp1;

public class App : Application
{
    private readonly MainWindow _mainWindow;

 
    public App(MainWindow mainWindow)
    {
        _mainWindow = mainWindow;
    }
    
    protected override void OnStartup(StartupEventArgs e)
    {
        _mainWindow.Show();
        base.OnStartup(e);
    }
}