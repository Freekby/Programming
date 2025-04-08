using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Contacts.ViewModel
{
    /// <summary>
    /// Конвертирует значение типа <see cref="bool"/> в <see cref="Visibility"/>.
    /// </summary>
    class BooleanToVisibilityConverter : IValueConverter
    {
        ///<inheritdoc/>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool boolValue = (bool)value;
            return boolValue ? Visibility.Visible : Visibility.Hidden;
        }

        ///<inheritdoc/>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
