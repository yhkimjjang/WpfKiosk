using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace WpfKiosk.Support.Local.ViewModels;

public class BaseWindowViewModel
{
    // Close 이벤트 등록
    public ICommand CloseWindowCommand { get; init; }

    public BaseWindowViewModel()
    {
        CloseWindowCommand = new RelayCommand(CloseWindow);
    }

    /// <summary>
    /// Close 버튼을 클릭 했을 때 원도우 종료 수행
    /// </summary>
    private void CloseWindow()
    {
        var rsult = MessageBox.Show("종료 하겠습니까?", "Close", MessageBoxButton.YesNo);
        if (rsult == MessageBoxResult.Yes)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
