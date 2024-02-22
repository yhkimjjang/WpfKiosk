using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using WpfKiosk.Forms.UI.Views;
using WpfKiosk.Support.UI.Units;

namespace WpfKiosk;

internal class App : PrismApplication
{
    protected override Window CreateShell()
    {
        return new KioskMainWindow();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }
}
