using System.Windows;

namespace WpfKiosk.Support.UI.Units;

public class BaseWindow : Window
{
    static BaseWindow()
    {
        DefaultStyleKeyProperty.OverrideMetadata(typeof(BaseWindow), new FrameworkPropertyMetadata(typeof(BaseWindow)));
    }
}
