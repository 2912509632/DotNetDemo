using System;
using System.Collections.Generic;
//导入命名空间
using System.ComponentModel;
using System.Globalization;

namespace _3_使用TypeConverter
{
    public class StringToStudentTypeConverter:TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
            {
                Student s = new Student();
                s.Name = value as string;
                return s;
            }
            return base.ConvertFrom(context, culture, value);
        }

    }
}
