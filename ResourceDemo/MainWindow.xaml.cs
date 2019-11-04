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
            var title = (string)this.FindResource("title");
            this.Resources["title"] = "改变了 title 资源数据";
        }
    }
}
