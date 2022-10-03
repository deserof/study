using System.ComponentModel;
using System.Reflection;

namespace lab8.Extensions
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum enumValue)
        {
            if (enumValue == null)
            {
                throw new ArgumentNullException(nameof(enumValue));
            }

            FieldInfo fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }

            return enumValue.ToString();
        }

        public static T GetEnumFromDescription<T>(string description) where T : Enum
        {
            Type type = typeof(T);

            if (!type.IsEnum)
            {
                throw new InvalidOperationException();
            }

            foreach (FieldInfo field in type.GetFields())
            {
                if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                    {
                        return (T)field.GetValue(null);
                    }
                }
                else
                {
                    if (field.Name == description)
                    {
                        return (T)field.GetValue(null);
                    }
                }
            }

            throw new ArgumentException("Not found.", nameof(description));
        }

        public static IEnumerable<string> GetDescriptions<T>()
            where T : Enum
        {
            var attributes = typeof(T).GetMembers()
                .SelectMany(x => x.GetCustomAttributes(typeof(DescriptionAttribute)).Cast<DescriptionAttribute>())
                .ToList();

            return attributes.Select(x => x.Description);
        }
    }
}
