using WpfKiosk.Application;
using WpfKiosk.Forms.Local.Views;
using WpfKiosk.Forms.UI.Views;

namespace WpfKiosk.Properties;

internal class WireDataContext : WpfKioskViewModelLocator
{
    protected override void Match(WpfKioskViewModelCollection collection)
    {
        collection.Register<KioskMainWindowViewModel>(typeof(KioskMainWindow));
    }
}
