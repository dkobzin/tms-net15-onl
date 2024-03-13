using System.ComponentModel;

namespace Lesson11Attributes;

public enum ExampleEnum
{
    [Description("First value")]
    FirstValue = 1,
    [Description("Second value")]
    SecondValue =2
}