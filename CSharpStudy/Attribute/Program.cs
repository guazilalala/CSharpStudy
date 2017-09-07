using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new Student()
            {
                Name = ""
                ,
                Age = 1
            };
            Console.WriteLine(CheckRequire(obj));
            Console.Read();
        }

        public static string CheckRequire<T>(T instance)
        {
            var validateMsg = new StringBuilder();

            Type t = typeof(T);

            var propertyInfos = t.GetProperties();

            foreach (var propertyInfo in propertyInfos)
            {
                //检查属性是否标记了特性
                RequireAttribute attribute = (RequireAttribute)Attribute.GetCustomAttribute(propertyInfo, typeof(RequireAttribute));

                //没标记直接跳过
                if (attribute == null)
                {
                    continue;
                }

                //获取该属性的数据类型
                var type = propertyInfo.PropertyType.ToString().ToLower();

                //获取该属性的值
                var value = propertyInfo.GetValue(instance);

                if (type.Contains("system.string"))
                {
                    if (string.IsNullOrEmpty((string)value) && attribute.IsRequire)
                    {
                        validateMsg.Append(propertyInfo.Name).Append("不能为空").Append(",");
                    }
                }
                else if (type.Contains("system.int"))
                {
                    if ((int)value == 0 && attribute.IsRequire)
                    {
                        validateMsg.Append(propertyInfo.Name).Append("必须大于0").Append(",");
                    }
                }
            }

            return validateMsg.ToString();
        }
    }
}
