using System.Runtime.InteropServices;
using Xarial.XCad.SolidWorks;

namespace WpfApp1.Services;

[ComVisible(true)]
public class Solidworks : SwAddInEx
{
    public override void OnConnect()
    {
        Application.ShowMessageBox("123");
    }
}