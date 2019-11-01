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
        public MainWindow()
        {
            this.InitializeComponent();

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
    }
}
