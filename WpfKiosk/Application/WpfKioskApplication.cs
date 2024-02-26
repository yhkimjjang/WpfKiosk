using Prism.Unity;

namespace WpfKiosk.Application;

internal abstract class WpfKioskApplication : PrismApplication
{
    /// <summary>
    /// ViewModel을 View에 종속성 주입시킴
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public WpfKioskApplication AddWirdDataContext<T>() where T : WpfKioskViewModelLocator, new()
    {
        WpfKioskViewModelLocator locator = new T();
        locator.Publish();
        return this;
    }
        
}
