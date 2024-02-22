using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfKiosk.Support.UI.Units
{
    public class CloseButton : Button
    {
        // Close 이벤트 Property 등록
        public static readonly DependencyProperty CloseCommandProperty = DependencyProperty.Register("CloseCommand", typeof(ICommand), typeof(CloseButton));

        static CloseButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CloseButton), new FrameworkPropertyMetadata(typeof(CloseButton)));
        }

        public ICommand CloseCommand
        {
            get => (ICommand)GetValue(CloseCommandProperty);
            set => SetValue(CloseCommandProperty, value);
        }

        public CloseButton()
        {
            Click += CloseButton_CloseWindow;
        }

        private void CloseButton_CloseWindow(object sender, RoutedEventArgs e)
        {
            CloseCommand?.Execute(this);
        }
    }
}
