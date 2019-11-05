using System.Windows;

namespace ResourceDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 自动查找本身元素的资源，不存在时向上层元素查找资源
            var title = (string)this.FindResource("title");

            // 如果明确知道资源所在的元素，可以通过Resources字典直接读写；
            this.Resources["title"] = "改变了 title 资源数据";
        }
    }
}
