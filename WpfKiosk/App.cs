using Prism.Ioc;
using Prism.Unity;
using System.Windows;
using WpfKiosk.Support.UI.Units;

namespace WpfKiosk;

internal class App : PrismApplication
{
    protected override Window CreateShell()
    {
        return new BaseWindow();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
    }
}
