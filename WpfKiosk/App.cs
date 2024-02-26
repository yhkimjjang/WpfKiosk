using Prism.Ioc;
using System.Windows;
using WpfKiosk.Application;
using WpfKiosk.Forms.UI.Views;

namespace WpfKiosk;

internal class App : WpfKioskApplication
{
    protected override Window CreateShell()
    {
        return new KioskMainWindow();
        //return new BaseWindow();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {

    }
}
