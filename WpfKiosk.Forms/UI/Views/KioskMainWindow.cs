using System.Windows;
using WpfKiosk.Support.UI.Units;

namespace WpfKiosk.Forms.UI.Views;

public class KioskMainWindow : BaseWindow
{
    static KioskMainWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(KioskMainWindow), new FrameworkPropertyMetadata(typeof(KioskMainWindow)));
    }
}
