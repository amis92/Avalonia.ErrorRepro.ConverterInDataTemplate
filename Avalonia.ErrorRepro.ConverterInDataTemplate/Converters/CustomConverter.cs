using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Avalonia.Markup;

namespace Avalonia.ErrorRepro.ConverterInDataTemplate.Converters
{
    public class CustomConverter : IValueConverter
    {
        public string Suffix { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"{value.GetType()} + {Suffix}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
