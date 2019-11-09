using System.Windows;
using System.Windows.Controls;

namespace PaintAnimationDemo
{
    /// <summary>
    /// TransformWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TransformWindow : Window
    {
        public TransformWindow()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 使用 ActualWidth 和 ActualHeight 获取实际尺寸
            if (!(sender is Button button)) return;
            this.Title = $"{button.ActualWidth} x {button.ActualHeight}";
        }
    }
}
