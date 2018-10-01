using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace _3_使用TypeConverter
{
    //标注特征类
    [TypeConverterAttribute(typeof(StringToStudentTypeConverter))]
    public class Student
    {
        public string Name { get; set; }

        public Student Stu { get; set; }
    }
}
