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

        private void transformButton_Click(object sender, RoutedEventArgs e)
        {
            new TransformWindow().Show();
        }

        private void animationButton_Click(object sender, RoutedEventArgs e)
        {
            new AnimationWindow().Show();
        }
    }
}
