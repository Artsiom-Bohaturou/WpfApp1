using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public const string hello = "Hello world";

        public void helloWorld()
        {
            int length = hello.Length;
        }
    }

}
