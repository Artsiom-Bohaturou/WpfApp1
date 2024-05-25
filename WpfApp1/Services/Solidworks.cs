using System.Runtime.InteropServices;
using System.ComponentModel;
using Xarial.XCad.Base.Attributes;
using Xarial.XCad.SolidWorks;

namespace WpfApp1.Services;


[ComVisible(true)]
public class AddIn : SwAddInEx
{
    public override void OnConnect()
    {
        Application.ShowMessageBox("Hello xCAD (.NET Framework)");
    }
}
