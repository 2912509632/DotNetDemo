using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace DataTemplate
{
    //名称转图片Logo
    public class NameToLogo : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string uriStr =@"Image/Logo/"+ value.ToString()+".jpg";
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    //名称转详细图片路径
    public class NameToImage : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string uriStr = @"Image/Detail/" + value.ToString() + ".jpg";
            return new BitmapImage(new Uri(uriStr, UriKind.Relative));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
