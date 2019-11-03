using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace DependencyPropertyDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            var school = new School() { SchoolName = "测试学校" };
            this.DataContext = school;

            // 两种方式绑定 School.SchoolNameProperty
            BindingOperations.SetBinding(
                this.schoolNameTextBox1,
                TextBox.TextProperty,
                new Binding(nameof(School.SchoolName))
                {
                    Source = school,
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                });

            BindingOperations.SetBinding(
                school,
                School.SchoolNameProperty,
                new Binding(nameof(TextBox.Text))
                {
                    Source = this.schoolNameTextBox2,
                    Mode = BindingMode.TwoWay,
                    UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                });

            // 使用附加属性
            var student = new Student();
            School.SetGrade(student, 9);
            _ = School.GetGrade(student);
        }
    }
}
