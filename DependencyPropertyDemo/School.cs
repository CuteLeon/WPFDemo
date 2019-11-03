using System.Windows;

namespace DependencyPropertyDemo
{
    // 依赖属性（DependencyProperty）需要依赖对象（DependencyObject）
    public class School : DependencyObject
    {
        /// <summary>
        /// 学校名称（CLR 属性）
        /// </summary>
        /// <remarks>手动封装一个 CLR 属性</remarks>
        public string SchoolName
        {
            get => (string)this.GetValue(School.SchoolNameProperty);
            set => this.SetValue(School.SchoolNameProperty, value);
        }

        /// <summary>
        /// 依赖属性
        /// </summary>
        /// <remarks>
        /// 代码片段名称：propa
        /// 需要修饰：public static readonly
        /// 数据结构：DependencyObject 存在一个静态 HashTable 类型，用于存储依赖属性的数据（使用组合模式，节省大量非必要依赖属性数据的内存）
        /// </remarks>
        public static readonly DependencyProperty SchoolNameProperty =
            DependencyProperty.RegisterAttached(
                nameof(School.SchoolName), // 注册属性名称
                typeof(string), // 属性数据类型
                typeof(School), // 绑定到的依赖对象类型
                new PropertyMetadata("默认值"));

        /// <summary>
        /// 用于 XAML 语法
        /// </summary>
        public int Grade
        {
            get => (int)this.GetValue(School.GradeProperty);
            set => this.SetValue(School.GradeProperty, value);
        }

        /// <summary>
        /// 用于后台代码
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        public static int GetGrade(Student student)
        {
            return (int)student.GetValue(GradeProperty);
        }

        public static void SetGrade(Student student, int value)
        {
            student.SetValue(GradeProperty, value);
        }

        /// <summary>
        /// 附加给 Student 的附加属性
        /// </summary>
        public static readonly DependencyProperty GradeProperty =
            DependencyProperty.RegisterAttached(nameof(School.Grade), typeof(int), typeof(Student), new PropertyMetadata(0));
    }
}
