using Prism.Mvvm;

namespace WpfKiosk.Application;

internal abstract class WpfKioskViewModelLocator
{
    /// <summary>
    /// WpfKioskViewModelCollection에 등록되어 있는 View와 ViewModel을
    /// <br/>ViewModelLocationProvider로 통해 종속성 주입화 시킴
    /// </summary>
    public void Publish()
    {
        var collection = new WpfKioskViewModelCollection();
        Match(collection);

        foreach (var item in collection.ViewModelDict)
        {
            ViewModelLocationProvider.Register(item.Key, item.Value);
        }
    }

    /// <summary>
    /// WpfKioskViewModelCollection에 필요한 View와 ViewModel을 등록함
    /// </summary>
    /// <param name="collection"></param>
    protected abstract void Match(WpfKioskViewModelCollection collection);
}
