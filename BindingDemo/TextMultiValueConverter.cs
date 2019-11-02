using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace BindingDemo
{
    public class TextMultiValueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            return values.Cast<string>().All(value => !string.IsNullOrEmpty(value));
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
