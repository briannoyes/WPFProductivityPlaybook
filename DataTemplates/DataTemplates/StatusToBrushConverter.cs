using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using System.Windows.Media;

namespace DataTemplates
{
    public class StatusToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is int)) return value; // Do nothing if wrong type
            switch ((int)value)
            {
                case 1:
                    return (SolidColorBrush)(new BrushConverter().ConvertFrom("#CD7F32"));
                case 2:
                    return new SolidColorBrush(Colors.Silver);
                case 3:
                    return new SolidColorBrush(Colors.Gold);
                default:
                    return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
