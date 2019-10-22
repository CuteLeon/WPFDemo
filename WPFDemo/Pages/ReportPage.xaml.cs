using System.Windows.Controls;

namespace WPFDemo.Pages
{
    /// <summary>
    /// ReportPage.xaml 的交互逻辑
    /// </summary>
    public partial class ReportPage : Page
    {
        public ReportPage()
        {
            this.InitializeComponent();
        }

        public ReportPage(object data) : this()
        {
            // 使用 DataContext 绑定数据
            this.DataContext = data;
        }
    }
}
