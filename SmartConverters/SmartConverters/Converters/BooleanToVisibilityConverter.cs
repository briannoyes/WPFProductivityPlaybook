using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace SmartConverters
{
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public Visibility FalseVisibility { get; set; }
        public bool Negate { get; set; }

        public BooleanToVisibilityConverter()
        {
            FalseVisibility = Visibility.Collapsed;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool bVal;
            bool result = bool.TryParse(value.ToString(), out bVal);

            if (!result) return value;

            if (bVal && !Negate || !bVal && Negate) return Visibility.Visible;

            return FalseVisibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
