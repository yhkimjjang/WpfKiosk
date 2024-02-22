using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Input;

namespace WpfKiosk.Support.Local.ViewModels;

public class BaseWindowViewModel
{
    public ICommand CloseWindowCommand { get; init; }

    public BaseWindowViewModel()
    {
        CloseWindowCommand = new RelayCommand(CloseWindow);
    }

    private void CloseWindow()
    {
        var rsult = MessageBox.Show("종료 하겠습니까?", "Close", MessageBoxButton.YesNo);
        if (rsult == MessageBoxResult.Yes)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
