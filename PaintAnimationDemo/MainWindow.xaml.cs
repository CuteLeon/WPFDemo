using System.Windows;

namespace PaintAnimationDemo
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

        private void effectButton_Click(object sender, RoutedEventArgs e)
        {
            new EffectWindow().Show();
        }
    }
}
