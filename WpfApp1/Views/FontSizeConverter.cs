using System.Globalization;
using System.Windows.Data;

namespace WpfApp1;

public class FontSizeConverter : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        if (values.Length == 2 && values[0] is double height && values[1] is double width)
        {
            double fontSize = Math.Min(height, width) / 7.0;
            return fontSize;
        }
        
        return 14.0;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}