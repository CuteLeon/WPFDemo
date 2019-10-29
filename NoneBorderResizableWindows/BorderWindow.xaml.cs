using System.Windows;
using System.Windows.Input;

namespace NoneBorderResizableWindows
{
    /// <summary>
    /// BorderWindow.xaml 的交互逻辑
    /// </summary>
    public partial class BorderWindow : Window
    {
        public BorderWindow()
        {
            this.InitializeComponent();
        }

        private void TitleGrid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // 鼠标左键拖动标题栏
            this.DragMove();
        }

        private void MinButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MaxRestoreButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
