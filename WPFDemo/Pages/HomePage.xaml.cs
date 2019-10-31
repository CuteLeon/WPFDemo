using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace WPFDemo.Pages
{
    /// <summary>
    /// HomePage.xaml 的交互逻辑
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var reportPage = new ReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(reportPage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var container = this.Content as Grid;
            var control = container.Children.Cast<UIElement>().Last();
            MessageBox.Show(LogicalTreeHelper.GetParent(control).GetType().Name);
        }
    }
}
