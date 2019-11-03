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

            /* RoutingStrategy 路由策略
             * Bubble : 冒泡，事件由源头沿着唯一明确的路径层层向上传递，直到处理或到达顶级；
             * Tunnel : 隧道，方向与 Bubble 相反，但路径相同，事件由顶级向源头传播；
             * Direct : 直达，原生的事件订阅模式；
             */

            // 使用后台代码监听路由事件
            this.gridRoot.AddHandler(Button.ClickEvent, new RoutedEventHandler(this.CSharp_Grid_Click));
        }

        private void XAML_Grid_Click(object sender, RoutedEventArgs e)
        {
            /* LogicalTree 展示逻辑上的控件（不包含用户控件内的子控件）
             * VisualTree 展示所有可见的控件（包含空户控件内的子控件）
             * e.OriginalSource 为 VisualTree 上的控件，可能为子控件
             * e.Source 为 LogicalTree 上的控件
             */
            MessageBox.Show($"XAML 绑定的路由事件：\n接收者：{(sender as Grid).Name}\n事件源头：{(e.OriginalSource as Button).Content}\n事件名称：{e.RoutedEvent.Name}\n事件策略：{e.RoutedEvent.RoutingStrategy}");

            if (new Random().NextDouble() > 0.5)
            {
                // Handled 标记事件已被处理，不再继续传播
                e.Handled = true;
            }
        }

        private void CSharp_Grid_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"CSharp 绑定的路由事件：\n接收者：{(sender as Grid).Name}\n事件源头：{(e.OriginalSource as Button).Content}\n事件名称：{e.RoutedEvent.Name}\n事件策略：{e.RoutedEvent.RoutingStrategy}");
        }

        private void gridMiddle_Click(object sender, RoutedEventArgs e)
        {
            Debug.Print($"{(e.OriginalSource as Button).Content} 的事件经过了 {(sender as Grid).Name}");
        }

        private void LeonButton_Click(object sender, RoutedEventArgs e)
        {
            Debug.Print($"{(sender as LeonButton).Tag} 收到了 {(e.OriginalSource as LeonButton).Tag} 的路由事件：{e.RoutedEvent.Name} ({e.RoutedEvent.RoutingStrategy.ToString()})");
        }
    }
}
