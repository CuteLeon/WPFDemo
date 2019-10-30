using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;

namespace TypeConverterDemo
{
    public class HumanTypeConverter : TypeConverter
    {
        /// <summary>
        /// 转换为 Human
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            Debug.Print($"{this.GetType().Name}.{nameof(this.ConvertFrom)}：Value = {value}");

            return
                value is string name ?
                new Human() { Name = name } :
                base.ConvertFrom(context, culture, value);
        }

        /// <summary>
        /// 转换为其他类型
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <param name="destinationType"></param>
        /// <returns></returns>
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            Debug.Print($"{this.GetType().Name}.{nameof(this.ConvertTo)}：Value = {value}");

            return value is Human human ?
                human.Name :
                base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
