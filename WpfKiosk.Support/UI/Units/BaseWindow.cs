using System.Windows;
using WpfKiosk.Support.Local.ViewModels;

namespace WpfKiosk.Support.UI.Units;

public class BaseWindow : Window
{
    static BaseWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(BaseWindow), new FrameworkPropertyMetadata(typeof(BaseWindow)));
    }
}
