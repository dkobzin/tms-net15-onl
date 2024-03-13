using System.ComponentModel;

namespace Lesson11Attributes;

public static class EnumExtensions
{
    public static string GetEnumDescription(this Enum value)
    {
        var fi = value.GetType().GetField(value.ToString());

        var attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

        if (attributes != null && attributes.Any())
        {
            return attributes.First().Description;
        }

        return value.ToString();
    }
}