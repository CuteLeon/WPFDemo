using System.Windows;

namespace TypeConverterDemo
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
            MessageBox.Show((this.FindResource("TheMan") as Human).Child.Name);
            MessageBox.Show((this.FindResource("AnotherMan") as Human).Child.Name);
        }
    }
}
