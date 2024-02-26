using WpfKiosk.Application;
using WpfKiosk.Properties;

namespace WpfKiosk;

internal class Starter
{
    [STAThread]
    public static void Main(string[] args)
    {
        new App()
            .AddWirdDataContext<WireDataContext>()
            .Run();
    }
}
