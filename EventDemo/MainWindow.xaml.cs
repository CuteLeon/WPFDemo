using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace EventDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            // 使用后台代码监听路由事件
            this.gridRoot.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.CSharp_Grid_Click));
        }

        private void XAML_Grid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"XAML 绑定的路由事件：\n接收者：{(sender as Grid).Name}\n事件源头：{(e.OriginalSource as Button).Content}\n事件名称：{e.RoutedEvent.Name}");

            if (new Random().NextDouble() > 0.5)
            {
                // Handled 标记事件已被处理，不再继续传播
                e.Handled = true;
            }
        }

        private void CSharp_Grid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"CSharp 绑定的路由事件：\n接收者：{(sender as Grid).Name}\n事件源头：{(e.OriginalSource as Button).Content}\n事件名称：{e.RoutedEvent.Name}");
        }

        private void gridMiddle_Click(object sender, RoutedEventArgs e)
        {
            Debug.Print($"{(e.OriginalSource as Button).Content} 的事件经过了 {(sender as Grid).Name}");
        }
    }
}
