using System.Globalization;

namespace DemoErrorMauiApp.Converters;
public class CandidatesConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        var v = (List<string>)value;

        if (v != null && v.Any())
        {
            return value;
        }

        return new List<string> { "" };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
