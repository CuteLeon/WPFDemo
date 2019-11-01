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

            Binding binding = new Binding
            {
                Source = this.ValueSlider,
                Path = new PropertyPath("Value"),
                StringFormat = "0.##",
            };

            BindingOperations.SetBinding(this.DisplayTextBox, TextBox.TextProperty, binding);
        }
    }
}
