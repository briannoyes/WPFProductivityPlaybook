#region using...
using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;
#endregion

namespace XamlNamespaces.Common.Converters
{
    public class NullToVisibilityConverter : MarkupExtension, IValueConverter
    {
        public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            if (value == null) return NullVisibility;

            return NotNullVisibility;
        }//Convert

        public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }//ConvertBack

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public Visibility NullVisibility { get; set; }
        public Visibility NotNullVisibility { get; set; }

        public NullToVisibilityConverter()
        {
            NullVisibility = Visibility.Collapsed;
            NotNullVisibility = Visibility.Visible;
        }

    }//class NullToVisibilityConverter
}
