using System.Runtime.InteropServices;
using System.ComponentModel;
using Xarial.XCad.Base.Attributes;
using Xarial.XCad.SolidWorks;

namespace WpfApp1.Services;


[Title("Sample Add-In")]
[Description("Sample 'Hello World' SOLIDWORKS add-in")]
[ComVisible(true), Guid("31B803E0-7A01-4841-A0DE-895B726625C9")]
public class Solidworks : SwAddInEx
{
    public override void OnConnect()
    {
        Application.ShowMessageBox("Hello World!");
    }
}
