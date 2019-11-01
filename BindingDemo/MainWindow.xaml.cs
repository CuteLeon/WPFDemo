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
    }
}
