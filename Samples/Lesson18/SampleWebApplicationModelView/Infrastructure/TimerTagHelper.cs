using Microsoft.AspNetCore.Razor.TagHelpers;

namespace SampleWebApplicationModelView.Infrastructure;

public class TimerTagHelper : TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";    
        output.Content.SetContent($"Current time: {DateTime.Now:HH:mm:ss}");
    }
}