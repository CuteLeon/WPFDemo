using System.Windows;

namespace NoneBorderResizableWindows
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

        private void NoneButton_Click(object sender, RoutedEventArgs e)
        {
            new NoneWindow().Show();
        }

        private void BorderButton_Click(object sender, RoutedEventArgs e)
        {
            new BorderWindow().Show();
        }
    }
}
