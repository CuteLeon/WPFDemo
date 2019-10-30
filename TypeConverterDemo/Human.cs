using System.ComponentModel;

namespace TypeConverterDemo
{
    // 使用特性修饰 Human 相关类型转换器
    [TypeConverter(typeof(HumanTypeConverter))]
    public class Human
    {
        public string Name { get; set; }

        public Human Child { get; set; }
    }
}
