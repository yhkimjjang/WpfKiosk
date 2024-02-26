namespace WpfKiosk.Application;

internal class WpfKioskViewModelCollection
{
    public Dictionary<string, Type> ViewModelDict { get; init; }

    public WpfKioskViewModelCollection()
    {
        ViewModelDict = new Dictionary<string, Type>();
    }

    /// <summary>
    /// ViewModel을 View에 종속성 주입 시킴
    /// </summary>
    /// <typeparam name="TViewModel">ViewModel</typeparam>
    /// <param name="viewType">View</param>
    public void Register<TViewModel>(Type viewType) where TViewModel : class
    {
        string className = viewType.ToString();
        ViewModelDict.Add(className, typeof(TViewModel));
    }
}
