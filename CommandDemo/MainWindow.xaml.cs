using System.CodeDom.Compiler;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace CommandDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RoutedCommand SubmitCommand = new RoutedCommand("Submit", typeof(MainWindow));

        public MainWindow()
        {
            this.InitializeComponent();
            this.InitializeCommand();

            // 直接把 Command 赋为 ViewModel
            this.DataContext = this.SubmitCommand;
        }

        private void InitializeCommand()
        {
            this.submitButton.Command = this.SubmitCommand;

            // 绑定快捷键
            this.SubmitCommand.InputGestures.Add(new KeyGesture(Key.S, ModifierKeys.Control));
            // 绑定命令目标
            this.submitButton.CommandTarget = this.messageTextBox;
            // 使用 MultiBinding 给命令传递多个参数
            var multiBinding = new MultiBinding();
            multiBinding.Converter = new MultiParameterValueConverter();
            multiBinding.Bindings.Add(new Binding(nameof(this.messageTextBox.Text)) { Source = this.messageTextBox });
            multiBinding.Bindings.Add(new Binding(nameof(this.submitButton.Name)) { Source = this.submitButton });
            this.submitButton.SetBinding(Button.CommandParameterProperty, multiBinding);

            // 增加命令绑定
            var commandBinding = new CommandBinding() { Command = this.SubmitCommand };

            /* PreviewCanExecute 和 CanExecute 事件由框架自动触发，且频率较高，会对性能造成影响，使用时务必谨慎
            // 是否允许执行前事件
            commandBinding.PreviewCanExecute += (s, e) => { e.Handled = true; };
            // 执行前事件
            commandBinding.PreviewExecuted += (s, e) => { e.Handled = true; };
             */
            // 是否允许执行事件（与事件源的 Enabled 属性关联）
            commandBinding.CanExecute += this.CommandBinding_CanExecute;
            // 执行后事件
            commandBinding.Executed += this.CommandBinding_Executed;

            // 将命令绑定添加到外围容器控件
            this.dockPanel.CommandBindings.Add(commandBinding);
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !string.IsNullOrEmpty(this.messageTextBox.Text);
            e.Handled = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show($"发送消息：\n{e.Parameter}");
            this.messageTextBox.Text = string.Empty;
            e.Handled = true;
        }
    }
}
