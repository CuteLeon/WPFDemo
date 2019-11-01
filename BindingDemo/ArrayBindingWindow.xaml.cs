using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace BindingDemo
{
    /// <summary>
    /// ArrayBindingWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ArrayBindingWindow : Window
    {
        public ArrayBindingWindow()
        {
            this.InitializeComponent();
            return;
            var wordList = new List<string>() { "Hello", "Hi", "Wink", "Greet" };
            this.textBox1.SetBinding(TextBox.TextProperty, new Binding("/") { Source = wordList });
            this.textBox2.SetBinding(TextBox.TextProperty, new Binding("/Length") { Source = wordList, Mode = BindingMode.OneWay });
            this.textBox3.SetBinding(TextBox.TextProperty, new Binding("/[4]") { Source = wordList, Mode = BindingMode.OneWay });
            this.textBox4.SetBinding(TextBox.TextProperty, new Binding("//") { Source = wordList, Mode = BindingMode.OneWay });
        }
    }
}
