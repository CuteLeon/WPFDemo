using System.Windows.Navigation;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : NavigationWindow
    {
        public static string WindowTitle { get; set; } = "WPF Demo !!!";

        public MainWindow()
        {
            this.InitializeComponent();
        }
    }
}
