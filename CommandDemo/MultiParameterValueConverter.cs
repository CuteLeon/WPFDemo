using System;
using System.Globalization;
using System.Windows.Data;

namespace CommandDemo
{
    public class MultiParameterValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return new { Message = values[0] as string, Source = values[1] as string };
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
            => new[] { value };
    }
}
