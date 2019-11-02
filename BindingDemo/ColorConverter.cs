using System;
using System.Globalization;
using System.Windows.Data;
using media = System.Windows.Media;
using draw = System.Drawing;

namespace BindingDemo
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var drawColor = draw.Color.FromName(value as string);
            var mediaColor = new media.Color() { A = 255, R = drawColor.R, G = drawColor.G, B = drawColor.B };
            return new media.SolidColorBrush(mediaColor);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((media.Color)value).ToString();
        }
    }
}
