using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace BindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string Title { get; set; } = "主窗口标题";

        public MainWindow()
        {
            this.InitializeComponent();

            this.SetBinding(Window.TitleProperty, new Binding(".") { Source = Title });

            // 还可以为 Binding 指定转换器，用于将封装数据属性和元素属性类型的转换或计算逻辑；
            this.DisplayTextBox.SetBinding(TextBox.TextProperty, new Binding("Value") { Source = this.ValueSlider });
            /* 或者
            Binding binding = new Binding
            {
                Source = this.ValueSlider,
                Path = new PropertyPath("Value"),
                StringFormat = "0.##",
            };

            BindingOperations.SetBinding(this.DisplayTextBox, TextBox.TextProperty, binding);
             */
        }

        private void arrayButton_Click(object sender, RoutedEventArgs e)
        {
            new ArrayBindingWindow().Show();
        }

        private void dataContextButton_Click(object sender, RoutedEventArgs e)
        {
            new DataContextWindow().Show();
        }

        private void itemSourceButton_Click(object sender, RoutedEventArgs e)
        {
            new ItemSourceWindow().Show();
        }
    }
}
